using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class JsonRead
    {
        public static void Main(string[] args)
        {
            string jsonData = File.ReadAllText("C:\\Users\\dell\\Documents\\web dev study\\JsonAssignment\\JsonAssignment\\data.json");
            dynamic user = JsonConvert.DeserializeObject<dynamic>(jsonData);

            Console.WriteLine("The name of user is: " + user.name);
            Console.WriteLine("The email of user is: " + user.email);
        }
    }
}
