using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    [TestClass]
    public class UserRegistrationTests
    {
        private UserRegistration registration;

        [TestInitialize]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [TestMethod]
        public void ValidUserRegistration_DoesNotThrow()
        {
            registration.RegisterUser("john", "john@mail.com", "secret123");
        }

        [TestMethod]
        public void InvalidUsername_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => registration.RegisterUser("", "john@mail.com", "secret123"));
        }

        [TestMethod]
        public void InvalidEmail_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => registration.RegisterUser("john", "johnmail.com", "secret123"));
        }

        [TestMethod]
        public void InvalidPassword_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => registration.RegisterUser("john", "john@mail.com", "123"));
        }
    }
}
