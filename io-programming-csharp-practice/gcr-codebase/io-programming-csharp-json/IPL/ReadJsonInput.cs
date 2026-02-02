using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.IPL
{
    internal class ReadJsonInput
    {
        public static List<IPLMatch> ReadFromJsonFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<IPLMatch>>(json);
        }

        public static void WriteToJsonFile(string filePath, List<IPLMatch> matches)
        {
            string json = JsonConvert.SerializeObject(matches, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
