using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class DivideByZeroTests
    {
        private DivideByZero divideByZero;

        [TestInitialize]
        public void Setup()
        {
            divideByZero = new DivideByZero();
        }

        [TestMethod]
        public void Divide_Test()
        {
            Assert.Throws<DivideByZeroException>(() => divideByZero.Divide(10, 0));
        }
    }
}
