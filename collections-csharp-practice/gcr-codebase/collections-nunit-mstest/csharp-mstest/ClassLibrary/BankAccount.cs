using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject.csharp_collections.assignment.MSTest
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double amount) => Balance += amount;

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException();
            Balance -= amount;
        }
    }
}
