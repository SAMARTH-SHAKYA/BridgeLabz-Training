using System.Runtime.InteropServices;
using System;
public class FitnessIMPL : IFitness
{
    public Person[] EntryMembers(Person[] personDatabase, ref int currIdx)
    {
        Console.WriteLine("Enter number of person you want to track");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 20 || num > 20 - currIdx)
        {
            Console.WriteLine("Enter Lesser number");
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter person's name");
                string name = Console.ReadLine();
                personDatabase[currIdx] = new Person(name);
                currIdx++;
            }
        }

        return personDatabase;
    }


    public void DisplayCurrentRankings(ref Person[] personDatabase, int currIdx)
    {
        Random random = new Random();

        // Assign random steps
        for (int i = 0; i < currIdx; i++)
        {
            double newSteps = random.Next(10, 101);
            double totalSteps = personDatabase[i].PersonCurrentSteps + newSteps;
            personDatabase[i].SetSteps(totalSteps);
        }

        // Bubble Sort (Descending by steps)
        for (int i = 0; i < currIdx - 1; i++)
        {
            for (int j = 0; j < currIdx - i - 1; j++)
            {
                if (personDatabase[j].PersonCurrentSteps < personDatabase[j + 1].PersonCurrentSteps)
                {
                    Person temp = personDatabase[j];
                    personDatabase[j] = personDatabase[j + 1];
                    personDatabase[j + 1] = temp;
                }
            }
        }

        // Print rankings
        Console.WriteLine("\n---- Current Rankings ----");
        for (int i = 0; i < currIdx; i++)
        {
            Console.WriteLine($"{i + 1}. {personDatabase[i].PersonName} - Steps: {personDatabase[i].PersonCurrentSteps}");
        }
    }

}