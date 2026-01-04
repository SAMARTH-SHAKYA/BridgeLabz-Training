using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Inheritance
{
    internal class AnimalHierarchy
    {
        //parent class animal
        class Animal
        {
            //global variables 
            public string Name { get; set; }
            public int Age { get; set; }

            public  void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }

        //child class dog
        class Dog : Animal
        {
            //overrinding the method
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        //child class cat
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        //chile class bird
        class Bird : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bird chirps");
            }
        }

    }
}
