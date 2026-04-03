using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    abstract class Bird
    {
        private string birdId;
        private string name;
        private string species;
        private string color;
        private int age;
        
        public Bird(string birdId, string name, string species, string color, int age)
        {
            this.birdId = birdId;   
            this.name = name;
            this.species = species;
            this.color = color;
            this.age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("------Bird Info------");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Bird ID --> {birdId}");
            Console.WriteLine($"Name --> {name}");
            Console.WriteLine($"Species --> {species}");
            Console.WriteLine($"Color --> {color}");
            Console.WriteLine($"Age --> {age}");
        }
    }
}
