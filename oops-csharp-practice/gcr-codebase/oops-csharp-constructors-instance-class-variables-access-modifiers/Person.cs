using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.Constructor
{
    internal class Person
    {
       
        
            public string Name;
            public int Age;

            // Parameterized constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            // Copy constructor
            public Person(Person other)
            {
                Name = other.Name;
                Age = other.Age;
            }
        

    }
}
