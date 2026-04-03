using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public int Price { get; set; }
    }


    public class carJson
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Brand = "Tata";
            car.Year = 2020;
            car.Price = 500000;

            string jsonCar = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(jsonCar);
        }
    }
}
