using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class TemperatureConverterTests
    {
        private TemperatureConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new TemperatureConverter();
        }

        [Test]
        public void CelsiusToFahrenheit_Test()
        {
            Assert.AreEqual(32, converter.CelsiusToFahrenheit(0));
        }

        [Test]
        public void FahrenheitToCelsius_Test()
        {
            Assert.AreEqual(0, converter.FahrenheitToCelsius(32));
        }
    }
}
