using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class PasswordValidatorTests
    {
        private PasswordValidator validator;

        [TestInitialize]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [TestMethod]
        public void ValidPassword_ReturnsTrue()
        {
            Assert.IsTrue(validator.IsValid("Password1"));
        }

        [TestMethod]
        public void Password_WithoutUppercase_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid("password1"));
        }

        [TestMethod]
        public void Password_WithoutDigit_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid("Password"));
        }

        [TestMethod]
        public void Password_TooShort_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid("Pass1"));
        }
    }
}
