using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    // main class bank account
    class BankAccount
    {
        //using get and set for field
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
    }

    //subclass savings account
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }
        public void DisplayAccountType() => Console.WriteLine("Savings Account");
    }

    //subclass checking account
    class CheckingAccount : BankAccount
    {
        public int WithdrawalLimit { get; set; }
        public void DisplayAccountType() => Console.WriteLine("Checking Account");
    }

    //sub class fixed deposit account
    class FixedDepositAccount : BankAccount
    {
        public int LockInPeriod { get; set; }
        public void DisplayAccountType() => Console.WriteLine("Fixed Deposit Account");
    }

}
