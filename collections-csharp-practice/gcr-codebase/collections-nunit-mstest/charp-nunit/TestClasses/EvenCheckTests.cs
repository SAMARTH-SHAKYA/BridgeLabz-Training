using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class EvenCheckTests
    {
        private EvenCheck evenCheck;

        [SetUp]
        public void Setup()
        {
            evenCheck = new EvenCheck();
        }

        [TestCase(2, true)]
        [TestCase(3, false)]
        [TestCase(10, true)]
        public void Even_Test(int num, bool exp)
        {
            Assert.AreEqual(exp, evenCheck.Even(num));
        }
    }
}
