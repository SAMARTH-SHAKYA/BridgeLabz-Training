
using System;
using System.Reflection;
using System.Text;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class JsonGeneration
    {
        public static string ToJson(object obj)
        {
            StringBuilder sb = new StringBuilder("{");
            foreach (FieldInfo f in obj.GetType().GetFields())
                sb.Append($"\"{f.Name}\":\"{f.GetValue(obj)}\",");
            sb.Length--;
            return sb.Append("}").ToString();
        }
    }

    class Person
    {
        public string Name;
        public int Age;
    }

    class JsonGenerator
    {
        static void Main()
        {
            Person p = new Person { Name = "Bob", Age = 40 };
            Console.WriteLine(JsonGeneration.ToJson(p));
        }
    }
}
