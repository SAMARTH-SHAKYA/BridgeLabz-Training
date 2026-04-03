using System;
class LargestAmongThree
{
    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if(num1>num2 && num1>num3)
        {
            Console.WriteLine($"The first number {num1} is largest");
        }
        else if(num2>num1 && num2>num3){
            Console.WriteLine($"The second number {num2} is largest");
        }
        else
        {
            Console.WriteLine($"The third number {num3} is largest");
        }
    }
}