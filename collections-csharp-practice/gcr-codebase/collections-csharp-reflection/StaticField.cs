
using System;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class Configuration
    {
        private static string API_KEY = "OLD_KEY";
    }

    class Intermediate_StaticField
    {
        static void Main()
        {
            FieldInfo field = typeof(Configuration).GetField(
                "API_KEY",
                BindingFlags.NonPublic | BindingFlags.Static);

            Console.WriteLine(field.GetValue(null));
            field.SetValue(null, "NEW_KEY");
            Console.WriteLine(field.GetValue(null));
        }
    }
}
