using System;

public class ParcelMenu
{
    private IParcelTracker utility;

    public ParcelMenu()
    {
        utility = new ParcelUtilityIMPL();
    }

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Parcel Tracker ---");
            Console.WriteLine("1. Add Parcel");
            Console.WriteLine("2. Move to Next Stage");
            Console.WriteLine("3. Track Parcel");
            Console.WriteLine("4. Mark Lost");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter parcel name: ");
                    utility.AddParcel(Console.ReadLine());
                    break;

                case 2:
                    Console.Write("Enter parcel name: ");
                    utility.MoveToNextStage(Console.ReadLine());
                    break;

                case 3:
                    Console.Write("Enter parcel name: ");
                    utility.TrackParcel(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Enter parcel name: ");
                    utility.MarkLost(Console.ReadLine());
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
