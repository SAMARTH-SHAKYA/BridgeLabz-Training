using System;
class EricTravel
{
    public static void Main(string[] args)
    {
        string fromCity = Console.ReadLine();
        string viaCity = Console.ReadLine();
        string toCity = Console.ReadLine();

        double fromToVia = Convert.ToDouble(Console.ReadLine());
        double fromToFinalCity = Convert.ToDouble(Console.ReadLine());

        int timeToVia = Convert.ToInt32(Console.ReadLine());
        int timeToFinalCity = Convert.ToInt32(Console.ReadLine());

        double distance = fromToVia+fromToFinalCity;
        int time = timeToFinalCity+timeToVia;

        Console.WriteLine($"The Total Distance travelled  from {fromCity} to {toCity} via {viaCity} is {distance} km and the Total Time taken is {time} minutes");
    }
}