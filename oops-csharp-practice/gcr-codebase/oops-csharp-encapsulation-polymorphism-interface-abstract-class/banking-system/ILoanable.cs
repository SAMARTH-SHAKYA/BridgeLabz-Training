using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.banking_system
{
    internal interface ILoanable
    {
        void ApplyForLoan(BankAccount account);
        double CalculateLoanEligibility(BankAccount account);
    }
}
