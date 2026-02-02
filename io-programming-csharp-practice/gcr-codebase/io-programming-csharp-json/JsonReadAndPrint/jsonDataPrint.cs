using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.JsonReadAndPrint
{
    internal class jsonDataPrint
    {
        public static void Main(string[] args)
        {
            string jsonData = File.ReadAllText("data.json");

            JObject jsonObj = JObject.Parse(jsonData);

            foreach (var prop in jsonObj)
            {
                Console.WriteLine(prop.Key + " : " + prop.Value);
            }
        }
    }
}
