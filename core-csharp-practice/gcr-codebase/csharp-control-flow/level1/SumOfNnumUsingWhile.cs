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

        double whileLoop = WhileLoop(n);

        Console.WriteLine($"From formula the sum is {formula} and using the while loop the sum is {whileLoop}");
    }

    public static double Formula(double n)
    {
        return  (n*(n+1))/2;
    }

    public static double WhileLoop(double n)
    {
        double sum = 0;
        while (n > 0)
        {
            sum += n;
            n--;
        }
        return sum;
    }
}