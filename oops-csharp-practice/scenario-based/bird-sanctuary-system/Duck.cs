using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    class Duck : Bird, ISwimmable
    {
        public Duck(string birdId, string name,
                     string species, string color,
                     int age) : base(birdId, name, species, color, age) { }

        public void Swim()
        {
            Console.WriteLine("Duck swims in the water");
        }
    }
}
