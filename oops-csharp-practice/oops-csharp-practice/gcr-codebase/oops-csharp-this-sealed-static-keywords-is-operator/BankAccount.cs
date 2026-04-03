using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Sealed
{
   

    class BankAccount
    {
        //global static variables
        public static string BankName = "ABC Bank";
        private static int totalAccounts = 0;

        //global non static varibales
        public int AccountNumber { get; private set; }
        public string AccountHolderName { get; set; }

        //callling the constructor
        public BankAccount(int accountNumber, string accountHolderName)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
            totalAccounts++;
        }


        //method to get total account
        public static void GetTotalAccounts()
        {
            Console.WriteLine("Total Accounts: " + totalAccounts);
        }

        //method to display obj
        public void Display(object obj)
        {
            if (obj is BankAccount)
            {
                Console.WriteLine($"Bank: {BankName}, Account No: {AccountNumber}, Holder: {AccountHolderName}");
            }
        }
    }

}
