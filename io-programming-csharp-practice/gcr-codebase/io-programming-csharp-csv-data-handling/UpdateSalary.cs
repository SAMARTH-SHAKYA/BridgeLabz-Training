
using System.IO;

class UpdateSalary
{
    static void Main()
    {
        using StreamReader r = new StreamReader("employees.csv");
        using StreamWriter w = new StreamWriter("updated.csv");
        w.WriteLine("ID,Name,Department,Salary");
        r.ReadLine();
        string line;
        while ((line = r.ReadLine()) != null)
        {
            var c = line.Split(',');
            decimal sal = decimal.Parse(c[3]);
            if (c[2] == "IT") sal *= 1.1m;
            w.WriteLine($"{c[0]},{c[1]},{c[2]},{sal}");
        }
    }
}
