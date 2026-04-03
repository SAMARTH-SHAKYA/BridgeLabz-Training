using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.IPL
{
    internal class CensorShipUtility
    {
        public static IPLMatch CensorshipApply(IPLMatch match)
        {
            match.FirstTeam = TeamMaskName(match.FirstTeam);
            match.SecondTeam = TeamMaskName(match.SecondTeam);
            match.WinnerTeam = TeamMaskName(match.WinnerTeam);

            match.POM = "REDACTED";

            return match;
        }

        private static string TeamMaskName(string team)
        {
            if (string.IsNullOrEmpty(team))
                return team;

            var parts = team.Split(' ');

            if (parts.Length > 1)
            {
                parts[1] = "***";
                return string.Join(" ", parts);
            }

            return team;
        }
    }
}
