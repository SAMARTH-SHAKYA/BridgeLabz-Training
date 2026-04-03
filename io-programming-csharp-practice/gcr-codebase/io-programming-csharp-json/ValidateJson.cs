using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json;

namespace JsonAssignment
{
    internal class ValidateJson
    {
        public static void Main(string[] args)
        {
            string schemaJson = @"
        {
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'email': { 'type': 'string' },
                'age': { 'type': 'integer' }
            },
            'required': ['name', 'email']
        }";

            // JSON to validate
            string jsonData = @"
        {
            'name': 'Aditey',
            'email': 'Aditey@gmail.com',
            'age': 21
        }";

            JSchema schema = JSchema.Parse(schemaJson);

            JObject jsonObject = JObject.Parse(jsonData);

            bool isValid = jsonObject.IsValid(schema, out IList<string> errors);

            if (isValid)
            {
                Console.WriteLine("JSON is VALID");
            }
            else
            {
                Console.WriteLine("JSON is INVALID");

                foreach (var error in errors)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}
