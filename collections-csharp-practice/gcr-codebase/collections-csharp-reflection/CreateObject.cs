using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class Student
    {
        public string Name;
        public Student(string name) { Name = name; }
    }
    internal class CreateObject
    {
        static void Main()
        {
            object obj = Activator.CreateInstance(typeof(Student), "Emma");
            Console.WriteLine(((Student)obj).Name);
        }
    }
}
