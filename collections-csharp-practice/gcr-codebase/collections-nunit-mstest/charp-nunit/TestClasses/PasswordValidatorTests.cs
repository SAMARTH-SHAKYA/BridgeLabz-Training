using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class PasswordValidatorTests
    {
        private PasswordValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [TestCase("Password1", true)]
        [TestCase("pass", false)]
        [TestCase("PASSWORD", false)]
        [TestCase("password1", false)]
        [TestCase("", false)]
        public void Password_Validation_Test(string pwd, bool expected)
        {
            Assert.AreEqual(expected, validator.IsValid(pwd));
        }
    }
}
