using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.CSVToJson
{
    internal class CsvToJson
    {
        static void Main()
        {
            string[] csvLines = File.ReadAllLines("data.csv");

            string[] headers = csvLines[0].Split(',');

            List<Dictionary<string, string>> jsonList =
                new List<Dictionary<string, string>>();

            for (int i = 1; i < csvLines.Length; i++)
            {
                string[] values = csvLines[i].Split(',');

                var obj = new Dictionary<string, string>();

                for (int j = 0; j < headers.Length; j++)
                {
                    obj[headers[j]] = values[j];
                }

                jsonList.Add(obj);
            }

            string jsonResult = JsonConvert.SerializeObject(jsonList, Formatting.Indented);

            Console.WriteLine(jsonResult);
        }
    }
}
