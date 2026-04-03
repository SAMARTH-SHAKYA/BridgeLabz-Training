using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.banking_system
{
    internal class LoanUtility : ILoanable
    {
        private string LoanId = "LN-9001";

        public void ApplyForLoan(BankAccount account)
        {
            Console.WriteLine($"Loan applied for {account.AccountNumber}");
        }

        public double CalculateLoanEligibility(BankAccount account)
        {
            return account.Balance * 5;
        }
    }
}
