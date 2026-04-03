using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.LoanBuddy
{
    internal class LoanMenu
    {
        private IApprovable approvable;

        public void Menu()
        {
            approvable = new LoanUtilityIMPL();

            Console.WriteLine("Welcome to loan bank");
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your credit score");
            double creditScore = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your income");
            double income = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the amount you want");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter what type you want to choose : home, car, education, personal, business");
            string loanType = Console.ReadLine();
            Console.WriteLine("Enter term in year/months");
            string loanTerm = Console.ReadLine();
            Console.WriteLine("Enter interest rate");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            Applicant applicant = new Applicant(name, creditScore, income, loanAmount);
            LoanApplication application = new LoanApplication(loanType, loanTerm, interestRate);


            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("Press 1 : to Check you loan is approved or not");
                Console.WriteLine("Press 2 : To check the emi ");
                Console.WriteLine("Press 3 : Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        approvable.ApproveLoan(applicant, application);
                        break;
                    case 2:
                        approvable.CalculateEMi(applicant, application);
                        break;
                    case 3:
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
