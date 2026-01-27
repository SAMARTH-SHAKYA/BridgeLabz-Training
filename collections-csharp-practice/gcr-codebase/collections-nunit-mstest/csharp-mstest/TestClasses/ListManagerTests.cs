using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class ListManagerTests
    {
        private ListManager listManager;
        private List<int> list;

        [TestInitialize]
        public void Setup()
        {
            listManager = new ListManager();
            list = new List<int>();
        }

        [TestMethod]
        public void AddElement_Test()
        {
            listManager.AddElement(list, 10);
            Assert.HasCount(1, list);
        }

        [TestMethod]
        public void RemoveElement_Test()
        {
            list.Add(10);
            listManager.RemoveElement(list, 10);
            Assert.HasCount(0, list);
        }

        [TestMethod]
        public void GetSize_Tests()
        {
            list.AddRange(new[] {1, 2, 3 });
            Assert.AreEqual(3, listManager.GetSize(list));
        }
    }
}
