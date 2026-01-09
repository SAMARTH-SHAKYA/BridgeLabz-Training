using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Scenario_oops.ATMDispenser
{
    internal class UtilityAtm
    {

        public void DispenseNotes(int userAmount)
        {
            Dictionary<int, int> notesDict = new Dictionary<int, int>();

            int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            int temp = userAmount;

            for (int i = 0; i < notes.Length; i++)
            {
                if(temp == 0)
                {
                    break;
                }
                else if (temp / notes[i] > 0)
                {
                    notesDict.Add(notes[i], temp / notes[i]);
                    temp = temp % notes[i];
                }
                
            }

            foreach (var item in notesDict) 
            {
                Console.WriteLine($"Denomination {item.Key} ---- count  {item.Value}");
               
            }
        }


        public void DispenseNotesWithout500(int userAmount)
        {
            Dictionary<int, int> notesDict = new Dictionary<int, int>();

            int[] notes = {200, 100, 50, 20, 10, 5, 2, 1 };

            int temp = userAmount;

            for (int i = 0; i < notes.Length; i++)
            {
                if (temp == 0)
                {
                    break;
                }
                else if (temp / notes[i] > 0)
                {
                    notesDict.Add(notes[i], temp / notes[i]);
                    temp = temp % notes[i];
                }

            }

            foreach (var item in notesDict)
            {
                Console.WriteLine($"Denomination {item.Key} ---- count  {item.Value}");

            }
        }


        public void DispenseNotesCondition(int userAmount)
        {
            Dictionary<int, int> notesDict = new Dictionary<int, int>();

            int[] notes = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            // max notes available per denomination
            Dictionary<int, int> noteLimits = new Dictionary<int, int>()
                                            {
                                                {500, 6},
                                                {200, 10},
                                                {100, 10},
                                                {50, 20},
                                                {20, 30},
                                                {10, 30},
                                                {5, 50},
                                                {2, 50},
                                                {1, 100}
                                            };

            int temp = userAmount;

            for (int i = 0; i < notes.Length; i++)
            {
                if (temp == 0)
                    break;

                int denom = notes[i];
                int maxAvailable = noteLimits[denom];

                int needed = temp / denom;

                int used = Math.Min(needed, maxAvailable);

                if (used > 0)
                {
                    notesDict.Add(denom, used);
                    temp -= denom * used;
                }
            }

            if (temp != 0)
            {
                Console.WriteLine("Not possible to dispense.");
                return;
            }

            Console.WriteLine("Dispensed Notes:");
            foreach (var item in notesDict)
            {
                Console.WriteLine($"Denomination ₹{item.Key} ---- Count {item.Value}");
            }
        }

    }
}
