using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.assignment.annotations
{
    // Attribute Definition
    [AttributeUsage(AttributeTargets.Property)]
    public class JsonFieldAttribute : Attribute
    {
        public string Name { get; set; }
    }

    // Applying the Attribute
    public class User
    {
        [JsonField(Name = "user_name")]
        public string Name { get; set; }

        [JsonField(Name = "age")]
        public int Age { get; set; }
    }

    // Serialization Logic
    public class JsonSerializer
    {
        public static string ToJson(object obj)
        {
            StringBuilder sb = new StringBuilder("{");

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                var attr = prop.GetCustomAttribute<JsonFieldAttribute>();
                if (attr != null)
                {
                    sb.Append($"\"{attr.Name}\":\"{prop.GetValue(obj)}\",");
                }
            }

            sb.Length--;
            sb.Append("}");
            return sb.ToString();
        }
    }
}
