using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class DateFormatterTests
    {
        private DateFormatter formatter;

        [TestInitialize]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [TestMethod]
        public void ValidDate_ReturnsFormattedDate()
        {
            Assert.AreEqual("25-12-2025", formatter.FormatDate("2025-12-25"));
        }

        [TestMethod]
        public void InvalidDate_ThrowsException()
        {
            Assert.Throws<FormatException>(() => formatter.FormatDate("25/12/2025"));
        }
    }
}
