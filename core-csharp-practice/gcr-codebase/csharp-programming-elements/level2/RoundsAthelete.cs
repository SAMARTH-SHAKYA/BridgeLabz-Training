using System;
class RoundsAthelete
{
    public static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        int perimeter = a+b+c;
        int rounds = 5000/perimeter;

        Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
        
    }
}