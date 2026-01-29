
using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSV
{
    static void Main()
    {
        Regex email = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        Regex phone = new Regex(@"^\d{10}$");

        using StreamReader r = new StreamReader("users.csv");
        r.ReadLine();
        string line;
        while ((line = r.ReadLine()) != null)
        {
            var c = line.Split(',');
            if (!email.IsMatch(c[2]) || !phone.IsMatch(c[3]))
                Console.WriteLine("Invalid: " + line);
        }
    }
}
