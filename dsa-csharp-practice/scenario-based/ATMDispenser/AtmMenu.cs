using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.ATMDispenser
{
    internal class AtmMenu
    {
        public void AtmMenuDispense()
        {
            int amount = Convert.ToInt32(Console.ReadLine());
            

            UtilityAtm atm = new UtilityAtm();
              
            atm.DispenseNotes(amount);

            atm.DispenseNotesWithout500(amount);

            atm.DispenseNotesCondition(amount);

        }
    }
}
