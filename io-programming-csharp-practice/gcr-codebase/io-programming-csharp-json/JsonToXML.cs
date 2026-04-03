using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JsonAssignment
{
    internal class JsonToXML
    {
        public static void Main()
        {
            string json = @"
        {
            'name': 'Aditey',
            'age': 21,
            'city': 'Jaunpur'
        }";

            // Convert JSON to XML
            XmlDocument xml = JsonConvert.DeserializeXmlNode(json, "User");

            Console.WriteLine(xml.OuterXml);
        }
    }
}
