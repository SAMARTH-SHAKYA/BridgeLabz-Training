using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using System.Threading;
using PayrollApp.Core.Models;

namespace PayrollApp.Core.Services
{
    public class PayrollService
    {
        private int connectionCounter = 0;
        private readonly object lockObject = new object();
        private readonly string connectionString =
            "Server=.\\SQLEXPRESS;Database=payroll_service;Trusted_Connection=True;TrustServerCertificate=True;";

        public long AddMultipleEmployees(List<Employee> employees)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var emp in employees)
                        {
                            string query = @"INSERT INTO EmployeePayroll
                                             (Name, Salary, StartDate)
                                             VALUES (@Name, @Salary, @StartDate)";

                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@Name", emp.Name);
                                command.Parameters.AddWithValue("@Salary", emp.Salary);
                                command.Parameters.AddWithValue("@StartDate", emp.StartDate);

                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        public long AddEmployeesWithoutThread(List<Employee> employees)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var emp in employees)
            {
                AddEmployeeToPayroll(emp);
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public long AddEmployeesWithThread(List<Employee> employees)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<Thread> threads = new List<Thread>();

            foreach (var emp in employees)
            {
                Thread thread = new Thread(() =>
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} STARTED for {emp.Name}");
                    AddEmployeeToPayroll(emp);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} COMPLETED for {emp.Name}");
                });

                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
                thread.Join();

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        private void AddEmployeeToPayroll(Employee emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Interlocked.Increment(ref connectionCounter);
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into employee_payroll
                        string employeeQuery = @"
                    INSERT INTO employee_payroll (Name, Salary, StartDate)
                    VALUES (@Name, @Salary, @StartDate);
                    SELECT SCOPE_IDENTITY();";

                        SqlCommand employeeCmd = new SqlCommand(employeeQuery, connection, transaction);

                        employeeCmd.Parameters.AddWithValue("@Name", emp.Name);
                        employeeCmd.Parameters.AddWithValue("@Salary", emp.Salary);
                        employeeCmd.Parameters.AddWithValue("@StartDate", emp.StartDate);

                        int employeeId = Convert.ToInt32(employeeCmd.ExecuteScalar());

                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} inserted employee {employeeId}");

                        // Insert into payroll_details
                        string payrollQuery = @"
                    INSERT INTO payroll_details 
                    (EmployeeId, BasicPay, Deductions, TaxablePay, IncomeTax, NetPay)
                    VALUES
                    (@EmployeeId, @BasicPay, @Deductions, @TaxablePay, @IncomeTax, @NetPay)";

                        SqlCommand payrollCmd = new SqlCommand(payrollQuery, connection, transaction);

                        payrollCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        payrollCmd.Parameters.AddWithValue("@BasicPay", emp.BasicPay);
                        payrollCmd.Parameters.AddWithValue("@Deductions", emp.Deductions);
                        payrollCmd.Parameters.AddWithValue("@TaxablePay", emp.TaxablePay);
                        payrollCmd.Parameters.AddWithValue("@IncomeTax", emp.IncomeTax);
                        payrollCmd.Parameters.AddWithValue("@NetPay", emp.NetPay);

                        payrollCmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void ResetCounter()
        {
            lock (lockObject)
            {
                connectionCounter = 0;
            }
        }
        public int GetConnectionCount()
        {
            lock (lockObject)
            {
                return connectionCounter;
            }
        }
    }
}