using NUnit.Framework;
using TestingProject.csharp_collections.assignment.Nunit;

namespace NunitProject.Nunit
{
    public class BankAccountTests
    {
        private BankAccount account;

        [SetUp]   // NUnit setup
        public void Setup()
        {
            account = new BankAccount();
        }

        [Test]
        public void Deposit_Test()
        {
            account.Deposit(500);
            Assert.AreEqual(500, account.Balance);
        }

        [Test]
        public void Withdraw_With_Sufficient_Balance_Test()
        {
            account.Deposit(500);
            account.Withdraw(200);
            Assert.AreEqual(300, account.Balance);
        }

        [Test]
        public void Withdraw_InsufficientBalance_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }
}
