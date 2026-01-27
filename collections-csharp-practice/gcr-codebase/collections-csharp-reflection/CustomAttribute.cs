
using System;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    [AttributeUsage(AttributeTargets.Class)]
    class AuthorAttribute : Attribute
    {
        public string Name { get; }
        public AuthorAttribute(string name) { Name = name; }
    }

    [Author("BridgeLabz")]
    class Book { }

    class CustomAttribute
    {
        static void Main()
        {
            AuthorAttribute attr =
                (AuthorAttribute)typeof(Book).GetCustomAttribute(typeof(AuthorAttribute));

            Console.WriteLine(attr.Name);
        }
    }
}
