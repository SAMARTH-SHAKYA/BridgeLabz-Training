using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.IPL
{
    public class IPLMatch
    {
        public string IdOfMatch { get; set; }
        public string FirstTeam { get; set; }
        public string SecondTeam { get; set; }
        public string WinnerTeam { get; set; }
        public string POM { get; set; }
        public string MatchVenue { get; set; }
    }
}
