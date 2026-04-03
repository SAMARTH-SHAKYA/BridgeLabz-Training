using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string birdId, string name,
                     string species, string color,
                     int age) : base(birdId, name, species, color, age) { }

        public void Fly()
        {
            Console.WriteLine("Sparrow flies in the sky");
        }
    }
}
