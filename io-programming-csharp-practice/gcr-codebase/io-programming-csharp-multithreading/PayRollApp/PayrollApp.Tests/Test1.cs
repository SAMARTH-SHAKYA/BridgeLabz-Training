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
    }
}