using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.LoanBuddy
{
    internal class LoanUtilityIMPL : IApprovable
    {
        private Applicant newApplicant;
        private LoanApplication newApplication;
        public void ApproveLoan(Applicant applicant, LoanApplication application)
        {
            newApplicant = new Applicant(applicant);
            newApplication = new LoanApplication(application);

            bool isApproved = false;
            string reason = "";

            string type = newApplication.LoanType.ToLower();
            double creditScore = newApplicant.ApplicantCreditScore;
            double income = newApplicant.ApplicantIncome;
            double loanAmount = newApplicant.ApplicantLoanAmount;

            switch (type)
            {
                case "home":
                    if (creditScore >= 700 && income >= 30000 && loanAmount <= 5000000)
                    {
                        isApproved = true;
                    }
                    else
                    {
                        reason = "Home loan requires Credit Score ≥ 700, Income ≥ 30000, Loan ≤ 50,00,000";
                    }
                    break;

                case "car":
                    if (creditScore >= 650 && income >= 20000 && loanAmount <= 1000000)
                    {
                        isApproved = true;
                    }
                    else
                    {
                        reason = "Car loan requires Credit Score ≥ 650, Income ≥ 20000, Loan ≤ 10,00,000";
                    }
                    break;

                case "education":
                    if (creditScore >= 600 && income >= 15000 && loanAmount <= 1500000)
                    {
                        isApproved = true;
                    }
                    else
                    {
                        reason = "Education loan requires Credit Score ≥ 600, Income ≥ 15000, Loan ≤ 15,00,000";
                    }
                    break;

                case "personal":
                    if (creditScore >= 680 && income >= 25000 && loanAmount <= 500000)
                    {
                        isApproved = true;
                    }
                    else
                    {
                        reason = "Personal loan requires Credit Score ≥ 680, Income ≥ 25000, Loan ≤ 5,00,000";
                    }
                    break;

                case "business":
                    if (creditScore >= 720 && income >= 40000 && loanAmount <= 3000000)
                    {
                        isApproved = true;
                    }
                    else
                    {
                        reason = "Business loan requires Credit Score ≥ 720, Income ≥ 40000, Loan ≤ 30,00,000";
                    }
                    break;

                default:
                    reason = "Invalid loan type!";
                    break;
            }

            if (isApproved)
            {
                Console.WriteLine("Loan Approved!");
                Console.WriteLine("Applicant: " + newApplicant.ApplicantName);
                Console.WriteLine("Loan Type: " + newApplication.LoanType);
                Console.WriteLine("Amount: " + newApplicant.ApplicantLoanAmount);
                Console.WriteLine("Interest Rate: " + newApplication.LoanInterestRate);
                Console.WriteLine("Term: " + newApplication.LoanTerm);
            }
            else
            {
                Console.WriteLine("Loan Rejected!");
                Console.WriteLine("Reason: " + reason);
            }
        }

        public void CalculateEMi(Applicant applicant, LoanApplication application)
        {
            double P = applicant.ApplicantLoanAmount;
            double annualRate = application.LoanInterestRate;
            string term = application.LoanTerm;

            int N = 0;

            //convert term to months
            if (term.ToLower().Contains("year"))
            {
                N = int.Parse(term.Split(' ')[0]) * 12;
            }
            else if (term.ToLower().Contains("month"))
            {
                N = int.Parse(term.Split(' ')[0]);
            }

            double R = annualRate / (12 * 100); //monthly interest rate

            double numerator = P * R * Math.Pow(1 + R, N);
            double denominator = Math.Pow(1 + R, N) - 1;

            double emi = numerator / denominator;

            Console.WriteLine("------ EMI DETAILS ------");
            Console.WriteLine("Applicant: " + applicant.ApplicantName);
            Console.WriteLine("Loan Type: " + application.LoanType);
            Console.WriteLine("Loan Amount: " + P);
            Console.WriteLine("Interest Rate: " + annualRate + "%");
            Console.WriteLine("Loan Term: " + term);
            Console.WriteLine("Monthly EMI: " + Math.Round(emi, 2));
        }
    }
}
