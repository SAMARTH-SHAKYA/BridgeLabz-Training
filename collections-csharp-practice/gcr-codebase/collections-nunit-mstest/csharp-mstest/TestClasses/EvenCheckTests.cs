using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class EvenCheckTests
    {
        private EvenCheck evenCheck;

        [TestMethod]
        [DataRow(2, true)]
        [DataRow(3, false)]
        [DataRow(10, true)]
        public void Even_Test(int num, bool exp)
        {
            evenCheck = new EvenCheck();
            Assert.AreEqual(exp, evenCheck.Even(num));
        }
    }
}
