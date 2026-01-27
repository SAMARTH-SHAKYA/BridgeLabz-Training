using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class StringUtilsTests
    {
        private StringUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [Test]
        public void Reverse_Test()
        {
            Assert.AreEqual("olleh", utils.Reverse("hello"));
        }

        [Test]
        public void Palindrome_Test()
        {
            Assert.IsTrue(utils.IsPalindrome("madam"));
            Assert.IsFalse(utils.IsPalindrome("hello"));
        }

        [Test]
        public void ToUpper_Test()
        {
            Assert.AreEqual("HELLO", utils.ToUpper("hello"));
        }
    }
}
