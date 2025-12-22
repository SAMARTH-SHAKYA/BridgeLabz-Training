using System;
class YearOfService
{
    public static void Main(string[] args)
    {
        double salary = Convert.ToDouble(Console.ReadLine());
        double yearOfService = Convert.ToDouble(Console.ReadLine());

        if(yearOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine(bonus);
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}