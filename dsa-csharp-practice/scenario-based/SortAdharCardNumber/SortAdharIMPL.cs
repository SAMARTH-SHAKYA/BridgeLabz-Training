
using System;
public class SortAdharIMPL : ISortAdhar
{

    //method to add details from the user
    public void AddDetails(ref AdharCard[] database, ref int index, string name, long number)
    {
        database[index] = new AdharCard(name, number);
        Console.WriteLine("Details added successfully to the database");
        index++;
        return;
    }

    //method to sort using radix sort
    public void RadixSortAdhar(ref AdharCard[] database, ref int index)
    {
        if (index == 0)
        {
            Console.WriteLine("Database is empty");
            return;
        }

        long max = database[0].AdharCardHolderNumber;
        for (int i = 1; i < index; i++)
        {
            if (database[i].AdharCardHolderNumber > max)
                max = database[i].AdharCardHolderNumber;
        }

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountSortByDigit(ref database, index, exp);
        }

        Console.WriteLine("Database sorted successfully!");
    }


    //radix sort uses count sort so making it private
    private void CountSortByDigit(ref AdharCard[] database, int n, long exp)
    {
        AdharCard[] output = new AdharCard[n];
        int[] count = new int[10];

        for (int i = 0; i < n; i++)
        {
            int digit = (int)((database[i].AdharCardHolderNumber / exp) % 10);
            count[digit]++;
        }

        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((database[i].AdharCardHolderNumber / exp) % 10);
            output[count[digit] - 1] = database[i];
            count[digit]--;
        }

        for (int i = 0; i < n; i++)
        {
            database[i] = output[i];
        }
    }



    public void PrintDatabase(AdharCard[] database, int index)
    {
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(database[i]);
        }
    }

}