using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class DivideByZeroTests
    {
        private DivideByZero divideByZero;

        [SetUp]
        public void Setup()
        {
            divideByZero = new DivideByZero();
        }

        [Test]
        public void Divide_ByZero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => divideByZero.Divide(10, 0));
        }
    }
}
