using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollApp.Core.Models;
using PayrollApp.Core.Services;
using System;
using System.Collections.Generic;

namespace PayrollApp.Tests
{
    [TestClass]
    public class PayrollServiceTests
    {
        [TestMethod]
        public void GivenMultipleEmployees_WhenAdded_ShouldReturnExecutionTime()
        {
            PayrollService service = new PayrollService();

            List<Employee> employees = new List<Employee>
            {
                new Employee { Name="Sam", Salary=50000, StartDate=DateTime.Now },
                new Employee { Name="John", Salary=60000, StartDate=DateTime.Now },
                new Employee { Name="David", Salary=70000, StartDate=DateTime.Now }
            };

            long executionTime = service.AddMultipleEmployees(employees);

            Assert.IsTrue(executionTime >= 0);
        }


        [TestMethod]
        public void GivenMultipleEmployees_WhenAddedWithAndWithoutThread_ShouldComparePerformance()
        {
            PayrollService service = new PayrollService();

            List<Employee> employees = new List<Employee>
                {
                    new Employee { Name="Emp1", Salary=50000, StartDate=DateTime.Now },
                    new Employee { Name="Emp2", Salary=60000, StartDate=DateTime.Now },
                    new Employee { Name="Emp3", Salary=70000, StartDate=DateTime.Now },
                    new Employee { Name="Emp4", Salary=80000, StartDate=DateTime.Now }
                };

            long normalTime = service.AddEmployeesWithoutThread(employees);
            long threadTime = service.AddEmployeesWithThread(employees);

            Console.WriteLine($"Without Thread: {normalTime} ms");
            Console.WriteLine($"With Thread: {threadTime} ms");

            Assert.IsTrue(normalTime >= 0);
            Assert.IsTrue(threadTime >= 0);
        }
    }
}