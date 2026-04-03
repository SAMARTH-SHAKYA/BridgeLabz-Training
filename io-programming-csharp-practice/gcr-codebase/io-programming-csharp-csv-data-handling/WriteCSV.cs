
using System.IO;

class WriteCSV
{
    static void Main()
    {
        using StreamWriter writer = new StreamWriter("employees.csv");
        writer.WriteLine("ID,Name,Department,Salary");
        writer.WriteLine("1,Alice,IT,60000");
        writer.WriteLine("2,Bob,HR,50000");
        writer.WriteLine("3,Charlie,Sales,55000");
        writer.WriteLine("4,David,Finance,65000");
        writer.WriteLine("5,Eve,IT,70000");
    }
}
