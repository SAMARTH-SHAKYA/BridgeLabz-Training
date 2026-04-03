using System;
class TotalSalary
{
    public static void Main(string[] args)
    {
        int salary = Convert.ToInt32(Console.ReadLine());
        int bonus = Convert.ToInt32(Console.ReadLine());

        int totalSalary = salary+bonus;

        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalSalary}");
        

    }
}