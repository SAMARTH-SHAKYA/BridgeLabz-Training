using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;

namespace JsonAssignment
{
    internal class ValidateEmail
    {
        static void Main()
        {
            // JSON Schema with email validation
            string schemaJson = @"
        {
          'type': 'object',
          'properties': {
            'name': { 'type': 'string' },
            'email': { 'type': 'string', 'format': 'email' }
          },
          'required': ['name', 'email']
        }";

            // JSON data to validate
            string jsonData = @"
        {
          'name': 'Aditey Rai',
          'email': 'aditey@gmail.com'
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
