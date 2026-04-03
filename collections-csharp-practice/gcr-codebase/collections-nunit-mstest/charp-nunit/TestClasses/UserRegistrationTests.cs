using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class UserRegistrationTests
    {
        private UserRegistration registration;

        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [Test]
        public void Valid_User_Should_Not_Throw()
        {
            Assert.DoesNotThrow(() =>
                registration.RegisterUser("Sam", "sam@email.com", "pass123"));
        }

        [Test]
        public void Invalid_Username_Should_Throw()
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser("", "sam@email.com", "pass123"));
        }

        [Test]
        public void Invalid_Email_Should_Throw()
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser("Sam", "samemail.com", "pass123"));
        }

        [Test]
        public void Invalid_Password_Should_Throw()
        {
            Assert.Throws<ArgumentException>(() =>
                registration.RegisterUser("Sam", "sam@email.com", "123"));
        }
    }
}
