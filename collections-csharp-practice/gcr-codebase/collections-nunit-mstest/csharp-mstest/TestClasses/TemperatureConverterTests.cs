using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private TemperatureConverter converter;

        [TestInitialize]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [TestMethod]
        public void CelsiusToFahrenheit_Test()
        {
            Assert.AreEqual(32, converter.CelsiusToFahrenheit(0));
            Assert.AreEqual(212, converter.CelsiusToFahrenheit(100));
        }

        [TestMethod]
        public void FahrenheitToCelsius_Test()
        {
            Assert.AreEqual(0, converter.FahrenheitToCelsius(32));
            Assert.AreEqual(100, converter.FahrenheitToCelsius(212));
        }
    }
}
