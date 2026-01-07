using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.banking_system
{
    internal abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public string HolderName { get; private set; }
        public double Balance { get; protected set; }

        protected BankAccount(string accountNumber, string holderName, double balance)
        {
            this.AccountNumber = accountNumber;
            this.HolderName = holderName;
            this.Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        public abstract double CalculateInterest();
    }
}
