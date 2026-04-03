using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class CalculatorTests
    {
        private CalculatorOperations calculatorOperations;

        [SetUp]
        public void Setup()
        {
            calculatorOperations = new CalculatorOperations();
        }

        [Test]
        public void Add_Test()
        {
            Assert.AreEqual(8, calculatorOperations.Add(5, 3));
        }

        [Test]
        public void Subtract_Test()
        {
            Assert.AreEqual(2, calculatorOperations.Subtract(5, 3));
        }

        [Test]
        public void Multiply_Test()
        {
            Assert.AreEqual(20, calculatorOperations.Multiply(5, 4));
        }

        [Test]
        public void Divide_Test()
        {
            Assert.AreEqual(5, calculatorOperations.Divide(15, 3));
        }

        [Test]
        public void Divide_ByZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => calculatorOperations.Divide(5, 0));
        }
    }
}
