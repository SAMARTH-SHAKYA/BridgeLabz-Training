
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BridgeLabzTraining.csharp_collections.assignment.reflection
{
    class ObjectMap
    {
        public static T ToObject<T>(Dictionary<string, object> data) where T : new()
        {
            T obj = new T();
            foreach (var item in data)
            {
                FieldInfo field = typeof(T).GetField(item.Key);
                if (field != null)
                    field.SetValue(obj, item.Value);
            }
            return obj;
        }
    }

    class User
    {
        public string Name;
        public int Age;
    }

    class ObjectMapper
    {
        static void Main()
        {
            var dict = new Dictionary<string, object>
            {
                { "Name", "Alice" },
                { "Age", 28 }
            };

            User user = ObjectMap.ToObject<User>(dict);
            Console.WriteLine(user.Name + " " + user.Age);
        }
    }
}
