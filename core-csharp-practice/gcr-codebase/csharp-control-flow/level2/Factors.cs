using System;
class Factors
{
    public static void Main(string[] args)
    {
        int variable = Convert.ToInt32(Console.ReadLine());

        for(int i = variable/2; i >= 1; i--)
        {
            if (variable % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}