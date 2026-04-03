using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class Employee
    {
        private int id;
        public string Name;
        public Employee() { }
        public Employee(int id) { this.id = id; }
        public void Work() { }
    }
    internal class GetClassInfo
    {
        static void Main()
        {
            Type type = typeof(Employee);

            Console.WriteLine("Constructors:");
            foreach (var c in type.GetConstructors(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                Console.WriteLine(c);

            Console.WriteLine("\nFields:");
            foreach (var f in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                Console.WriteLine(f.Name);

            Console.WriteLine("\nMethods:");
            foreach (var m in type.GetMethods(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                Console.WriteLine(m.Name);
        }
    }
}
