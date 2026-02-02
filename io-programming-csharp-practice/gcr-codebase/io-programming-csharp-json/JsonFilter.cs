using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment
{

    internal class JsonFilter
    {
        public static void Main(String[] args)
        {
            string jsonData = @"
        [
          { 'name': 'Rahul', 'age': 22 },
          { 'name': 'Amit',  'age': 28 },
          { 'name': 'Neha',  'age': 30 },
          { 'name': 'Riya',  'age': 24 }
        ]";

            JArray users = JArray.Parse(jsonData);

            var result = users
                .Where(u => (int)u["age"] > 25);

            Console.WriteLine("Users with Age > 25:");

            foreach (var user in result)
            {
                Console.WriteLine(user["name"] + " - " + user["age"]);
            }
        }
    }
}
