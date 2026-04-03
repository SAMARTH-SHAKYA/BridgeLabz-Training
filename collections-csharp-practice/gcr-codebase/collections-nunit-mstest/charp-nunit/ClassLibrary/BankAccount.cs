using System;

namespace TestingProject.csharp_collections.assignment.Nunit
{
    public class BankAccount
    {
        public double Balance { get; private set; }

        public void Deposit(double amount) => Balance += amount;

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance");
            Balance -= amount;
        }
    }
}
