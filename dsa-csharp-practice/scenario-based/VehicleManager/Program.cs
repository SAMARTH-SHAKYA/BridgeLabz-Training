using System;

class Program
{
    static void Main()
    {
        TrafficUtility utility = new TrafficUtility();

        while (true)
        {
            utility.ShowMenu();
            int choice = Convert.ToInt32(Console.ReadLine());
            utility.HandleChoice(choice);
        }
    }
}