using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAssignment
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    internal class ListToJsonArray
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
        {
            new Car { Brand = "Toyota", Model = "Corolla", Year = 2020 },
            new Car { Brand = "Honda",  Model = "Civic",   Year = 2021 },
            new Car { Brand = "Ford",   Model = "Mustang", Year = 2022 }
        };

            // Convert list to JSON array
            string jsonArray = JsonConvert.SerializeObject(cars, Formatting.Indented);

            Console.WriteLine(jsonArray);
        }
    }
}
