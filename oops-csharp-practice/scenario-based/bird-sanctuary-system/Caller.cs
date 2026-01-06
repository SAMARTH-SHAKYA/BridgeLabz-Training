using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird[] birds = new Bird[5];

            birds[0] = new Eagle("B1", "Eagle One", "Eagle", "Brown", 5);
            birds[1] = new Sparrow("B2", "Sparrow One", "Sparrow", "Grey", 2);
            birds[2] = new Duck("B3", "Duck One", "Duck", "White", 3);
            birds[3] = new Penguin("B4", "Penguin One", "Penguin", "Black & White", 4);
            birds[4] = new Seagull("B5", "Seagull One", "Seagull", "White", 3);

            Console.WriteLine("===== BIRD SANCTUARY REPORT =====\n");

            foreach (Bird bird in birds)
            {
                Console.WriteLine("--------------------------------");
                bird.DisplayInfo();

                if (bird is IFlyable flyableBird)
                {
                    flyableBird.Fly();
                }

                if (bird is ISwimmable swimmableBird)
                {
                    swimmableBird.Swim();
                }

                Console.WriteLine("--------------------------------");
            }
        }
    }
}
