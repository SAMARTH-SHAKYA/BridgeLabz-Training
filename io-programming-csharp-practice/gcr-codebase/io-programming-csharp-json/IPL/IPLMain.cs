using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.IPL
{
    internal class IPLMain
    {
        public static void Main()
        {
            Console.WriteLine("Choose Input Format:");
            Console.WriteLine("1 - JSON");
            Console.WriteLine("2 - CSV");

            int choosen = int.Parse(Console.ReadLine());

            List<IPLMatch> matchesList = null;

            if (choosen == 1)
            {
                matchesList = ReadJsonInput.ReadFromJsonFile("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\IPL\\jsonInput.json");
            }
            else if (choosen == 2)
            {
                matchesList = CSVUtility.ReadFromCsvFile("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\IPL\\csvInput.csv");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }

            List<IPLMatch> censoredMatchesList = new List<IPLMatch>();

            foreach (var match in matchesList)
            {
                censoredMatchesList.Add(CensorShipUtility.CensorshipApply(match));
            }

            // Write Output
            ReadJsonInput.WriteToJsonFile("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\IPL\\jsonOutput.json", censoredMatchesList);
            CSVUtility.WriteToCsvFile("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\IPL\\csvOutput.csv", censoredMatchesList);

            Console.WriteLine("Censorship Processing Completed!");
            Console.WriteLine("Files Generated:");
            Console.WriteLine("- censored_output.json");
            Console.WriteLine("- censored_output.csv");
        }
    }
}
