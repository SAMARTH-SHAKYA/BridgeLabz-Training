using System;
class Chocolate
{
    public static void Main(string[] args)
    {
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int divided = numberOfChocolates/numberOfChildren;
        int remaining = numberOfChocolates%numberOfChildren;

        Console.WriteLine($"The number of chocolates each child gets is {divided} and the number of remaining chocolates is {remaining}");
    }
}