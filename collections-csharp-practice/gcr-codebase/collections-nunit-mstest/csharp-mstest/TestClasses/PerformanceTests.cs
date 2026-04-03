using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class PerformanceTests
    {
        private PerformanceService service;

        [TestInitialize]
        public void Setup()
        {
            service = new PerformanceService();
        }

        [TestMethod]
        [Timeout(4000)] // 4 seconds (4000 ms)
        public void LongRunningTask_ShouldTimeout()
        {
            service.LongRunningTask();
        }
    }
}
