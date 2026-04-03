using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.LoanBuddy
{
    internal interface IApprovable
    {
        public void ApproveLoan(Applicant applicant,LoanApplication application);

        public void CalculateEMi(Applicant applicant, LoanApplication application);
    }
}
