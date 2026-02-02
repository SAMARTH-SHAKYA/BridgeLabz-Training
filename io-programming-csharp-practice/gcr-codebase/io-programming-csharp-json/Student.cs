using System;
using Newtonsoft.Json;

namespace JsonAssignment
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string[] subjects { get; set; }
    }

    public class StudentJson
    {
        public static void Main(string[] args)
        {
            Student student = new Student();

            student.name = "Aditey";
            student.age = 21;
            student.subjects = new string[] { "Maths", "English" };

            string studentJson = JsonConvert.SerializeObject(student, Formatting.Indented);

            Console.WriteLine(studentJson);

        }
    }
}

