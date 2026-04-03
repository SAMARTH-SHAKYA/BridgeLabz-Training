using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.LoanBuddy
{
    internal class Applicant
    {
        public string ApplicantName {  get; private set; }
        public double ApplicantCreditScore { get; private set; }

        public double ApplicantIncome {  get; private set; }

        public double ApplicantLoanAmount { get; private set; }

        public Applicant(string name,double creditScore,double income,double loanAmount) 
        {
            this.ApplicantName = name;
            this.ApplicantCreditScore = creditScore;
            this.ApplicantIncome = income;
            this.ApplicantLoanAmount = loanAmount;
        }


        public Applicant(Applicant other)
        {
            this.ApplicantName = other.ApplicantName;
            this.ApplicantCreditScore = other.ApplicantCreditScore;
            this.ApplicantIncome = other.ApplicantIncome;
            this.ApplicantLoanAmount = other.ApplicantLoanAmount;
        }

    }
}
