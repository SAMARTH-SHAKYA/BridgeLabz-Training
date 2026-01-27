using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MsTestProject.MSTest
{
    [TestClass]
    public class CalculatorTests
    {
        private CalculatorOperations calculatorOperations;

        [TestInitialize]
        public void Setup()
        {
            calculatorOperations = new CalculatorOperations();
        }

        [TestMethod]
        public void Add_Test()
        {
            Assert.AreEqual(8, calculatorOperations.Add(5, 3));
        }

        [TestMethod]
        public void Substract_Test()
        {
            Assert.AreEqual(2, calculatorOperations.Subtract(5, 3));
        }

        [TestMethod]
        public void Multiply_Test()
        {

            Assert.AreEqual(20, calculatorOperations.Multiply(5, 4));
        }

        [TestMethod]
        public void Divide_Tests()
        {
            Assert.AreEqual(5, calculatorOperations.Divide(15, 3));
        }

        [TestMethod]
        public void Divide_ByZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => calculatorOperations.Divide(5, 0));
        }
    }
}
