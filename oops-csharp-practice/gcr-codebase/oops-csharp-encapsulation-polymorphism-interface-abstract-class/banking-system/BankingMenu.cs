using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops_csharp_encapsulation_polymorphism_interface_abstract_class.banking_system
{
    internal class BankingMenu
    {
        private ILoanable loanUtility;

        public void Menu()
        {
            loanUtility = new LoanUtility();

            BankAccount account =
                new SavingsAccount("SB101", "Samarth", 50000);

            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : Deposit");
                Console.WriteLine("Press 2 : Withdraw");
                Console.WriteLine("Press 3 : Check balance");
                Console.WriteLine("Press 4 : Calculate interest");
                Console.WriteLine("Press 5 : Loan eligibility");
                Console.WriteLine("Press 6 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account.Deposit(5000);
                        Console.WriteLine("Amount deposited");
                        break;

                    case 2:
                        account.Withdraw(3000);
                        Console.WriteLine("Amount withdrawn");
                        break;

                    case 3:
                        Console.WriteLine(account.Balance);
                        break;

                    case 4:
                        Console.WriteLine(account.CalculateInterest());
                        break;

                    case 5:
                        loanUtility.ApplyForLoan(account);
                        Console.WriteLine(loanUtility.CalculateLoanEligibility(account));
                        break;

                    case 6:
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
