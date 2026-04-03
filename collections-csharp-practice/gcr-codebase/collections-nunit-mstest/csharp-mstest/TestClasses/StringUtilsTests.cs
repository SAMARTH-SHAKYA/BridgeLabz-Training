using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class StringUtilsTests
    {
        private StringUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new StringUtils();
        }
        [TestMethod]
        public void Reverse_Test()
        {
            Assert.AreEqual("cba", utils.Reverse("abc"));
        }

        [TestMethod]
        public void IsPalindrome_Test()
        {
            Assert.IsTrue(utils.IsPalindrome("cbc"));
        }

        [TestMethod]
        public void IsUppercase_Test()
        {
            Assert.AreEqual("ABC", utils.ToUpper("abc"));
        }
    }
}
