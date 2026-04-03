using System;
class IsFirstSmallest
{
    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if(num1<num2 && num1 < num3)
        {
            Console.WriteLine($"The first number {num1} is smallest");
        }
        else
        {
            Console.WriteLine($"The first number {num1} is not smallest");
        }
    }
}