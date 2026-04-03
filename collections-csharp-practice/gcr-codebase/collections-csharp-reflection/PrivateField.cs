using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class Person
    {
        private int age = 20;
    }
    internal class PrivateField
    {
        static void Main()
        {
            Person p = new Person();
            FieldInfo field = typeof(Person).GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine(field.GetValue(p));
            field.SetValue(p, 30);
            Console.WriteLine(field.GetValue(p));
        }
    }
}
