using System.Runtime.CompilerServices;
using System;
public class FitnessMenu
{
    private IFitness fitness;

    public void Menu()
    {
        Console.WriteLine("Welcome to fitness tracker");

        fitness = new FitnessIMPL();
        Person[] personDatabase = new Person[20];
        int personDatabaseIdx = 0;

        bool isTrue = true;

        while (isTrue)
        {
            Console.WriteLine(personDatabaseIdx);
            Console.WriteLine("Press 0 : Exit");
            Console.WriteLine("Press 1 : Entry of persons tracked");
            Console.WriteLine("Press 2 : To update rankings");
            

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    isTrue = false;
                    Console.WriteLine("Exiting the console ----- Thank you");
                    break;
                
                case 1:
                    fitness.EntryMembers(personDatabase,ref personDatabaseIdx);
                    break;

                case 2:
                    fitness.DisplayCurrentRankings(ref personDatabase, personDatabaseIdx);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

    }
}