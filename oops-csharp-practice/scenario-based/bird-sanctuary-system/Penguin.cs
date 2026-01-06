using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    class Penguin : Bird, ISwimmable
    {
        public Penguin(string birdId, string name,
                     string species, string color,
                     int age) : base(birdId, name, species, color, age) { }

        public void Swim()
        {
            Console.WriteLine("Penguin swims in the water");
        }
    }
}
