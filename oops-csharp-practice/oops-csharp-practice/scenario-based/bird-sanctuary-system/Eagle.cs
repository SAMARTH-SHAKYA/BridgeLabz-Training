using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    class Eagle : Bird, IFlyable
    {
        public Eagle(string birdId, string name,
                     string species, string color,
                     int age) : base(birdId, name, species, color, age) { }

        public void Fly()
        {
            Console.WriteLine("Eagle flies in the sky");
        }

    }
}
