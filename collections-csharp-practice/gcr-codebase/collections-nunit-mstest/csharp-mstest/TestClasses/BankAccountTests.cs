using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProject.csharp_collections.assignment.MSTest;

namespace MsTestProject.MSTest
{
    internal class BankAccountTests
    {
        private BankAccount account;

        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount();
        }

        [TestMethod]
        public void Deposit_Test()
        {
            account.Deposit(500);
            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
        public void Withdraw_InsufficientBalance_Test()
        {
            account.Withdraw(100);
        }
    }
}
