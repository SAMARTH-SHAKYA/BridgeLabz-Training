using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment.MergeTwoJsonObjects
{
    internal class MergeJson
    {
        public static void Main(string[] args)
        {
            string json1 = File.ReadAllText("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\MergeTwoJsonObjects\\user1.json");
            string json2 = File.ReadAllText("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\MergeTwoJsonObjects\\user2.json");

            JObject jsonObj1 = JObject.Parse(json1);
            JObject jsonObj2 = JObject.Parse(json2);

            jsonObj1.Merge(jsonObj2);

            Console.WriteLine("Merged object is: ");
            Console.WriteLine(jsonObj1.ToString());
        }
    }
}
