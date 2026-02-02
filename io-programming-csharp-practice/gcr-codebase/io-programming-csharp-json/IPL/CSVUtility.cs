using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.IPL
{
    internal class CSVUtility
    {
        public static List<IPLMatch> ReadFromCsvFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            List<IPLMatch> matchesList = new List<IPLMatch>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                IPLMatch match = new IPLMatch
                {
                    IdOfMatch = values[0],
                    FirstTeam = values[1],
                    SecondTeam = values[2],
                    WinnerTeam = values[3],
                    POM = values[4],
                    MatchVenue = values[5]
                };

                matchesList.Add(match);
            }

            return matchesList;
        }

        public static void WriteToCsvFile(string filePath, List<IPLMatch> matches)
        {
            List<string> linesList = new List<string>
        {
            "MatchId,Team1,Team2,Winner,PlayerOfMatch,Venue"
        };

            foreach (var m in matches)
            {
                linesList.Add($"{m.IdOfMatch},{m.FirstTeam},{m.SecondTeam},{m.WinnerTeam},{m.POM},{m.MatchVenue}");
            }

            File.WriteAllLines(filePath, linesList);
        }
    }
}
