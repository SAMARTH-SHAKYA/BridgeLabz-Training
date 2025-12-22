using System;
class SumOfNnumUsingWhile
{
    public static void Main(string[] args)
    {
        double n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not valid");
        }

        double formula = Formula(n);

        double forLoop = ForLoop(n);

        Console.WriteLine($"From formula the sum is {formula} and using the for loop the sum is {forLoop}");
    }

    public static double Formula(double n)
    {
        return  (n*(n+1))/2;
    }

    public static double ForLoop(double n)
    {
        double sum = 0;
        for(int i = 1; i <= n; i++)
        {
            sum+=i;
        }
        return sum;
    }
}