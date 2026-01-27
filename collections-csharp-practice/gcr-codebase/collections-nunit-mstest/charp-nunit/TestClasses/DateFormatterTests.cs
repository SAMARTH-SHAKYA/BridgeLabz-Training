using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class DateFormatterTests
    {
        private DateFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [Test]
        public void ValidDate_ReturnsFormattedDate()
        {
            Assert.AreEqual("25-12-2025", formatter.FormatDate("2025-12-25"));
        }

        [Test]
        public void InvalidDate_ThrowsException()
        {
            Assert.Throws<FormatException>(() => formatter.FormatDate("25/12/2025"));
        }
    }
}
