using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class PerformanceServiceTests
    {
        private PerformanceService service;

        [SetUp]
        public void Setup()
        {
            service = new PerformanceService();
        }

        [Test]
        [Timeout(4000)]  // must finish within 4 sec
        public void LongRunningTask_Test()
        {
            int result = service.LongRunningTask();
            Assert.AreEqual(1, result);
        }
    }
}
