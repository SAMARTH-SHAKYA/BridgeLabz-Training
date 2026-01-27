using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.Nunit

{
    public class PerformanceService
    {
        public int LongRunningTask()
        {
            Thread.Sleep(3000); // 3 seconds
            return 1;
        }
    }
}
