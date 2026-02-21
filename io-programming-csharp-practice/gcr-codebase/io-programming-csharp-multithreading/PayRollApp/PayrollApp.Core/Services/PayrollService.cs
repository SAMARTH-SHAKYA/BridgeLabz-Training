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
                AddEmployee(emp);
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
                Thread thread = new Thread(() => AddEmployee(emp));
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join(); // wait for all threads
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        private void AddEmployee(Employee emp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO EmployeePayroll
                         (Name, Salary, StartDate)
                         VALUES (@Name, @Salary, @StartDate)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", emp.Name);
                    command.Parameters.AddWithValue("@Salary", emp.Salary);
                    command.Parameters.AddWithValue("@StartDate", emp.StartDate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}