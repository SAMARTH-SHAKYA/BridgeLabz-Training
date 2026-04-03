using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    class Seagull : Bird, ISwimmable, IFlyable
    {
        public Seagull(string birdId, string name,
                     string species, string color,
                     int age) : base(birdId, name, species, color, age) { }

        public void Fly()
        {
            Console.WriteLine("Seagull flies in the sky");
        }

        public void Swim()
        {
            Console.WriteLine("Seagull swims in the water");
        }
    }
}
