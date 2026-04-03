using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.LoanBuddy
{
    internal class LoanApplication
    {
        public string LoanType { get; private set; }
        public string LoanTerm { get;  private set; }

        
        public double LoanInterestRate { get; private set; }

        public LoanApplication(string type,string term,double interestRate) 
        {
            this.LoanType = type;
            this.LoanTerm = term;
            this.LoanInterestRate = interestRate;
        }

        public LoanApplication(LoanApplication other)
        {
            this.LoanType = other.LoanType;
            this.LoanTerm = other.LoanTerm;
            this.LoanInterestRate = other.LoanInterestRate;
        }

    }
}
