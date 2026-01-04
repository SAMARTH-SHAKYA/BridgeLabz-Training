using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    class BankAccount
    {
        //global varaibles
        public int accountNumber;
        protected string accountHolder;
        private double balance;

        //calling the constructor
        public BankAccount(int accNo, string holder, double balance)
        {
            accountNumber = accNo;
            accountHolder = holder;
            this.balance = balance;
        }

        //method to get balance
        public double GetBalance()
        {
            return balance;
        }

        //method to set balance
        public void SetBalance(double amount)
        {
            balance = amount;
        }
    }

    //creating the subclass
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accNo, string holder, double balance)
            : base(accNo, holder, balance) { }

        public void Display()
        {
            Console.WriteLine($"Account No: {accountNumber}, Holder: {accountHolder}");
        }
    }
}
