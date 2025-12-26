using System;
using System.Security.AccessControl;
class SecondLargest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter count of numbers you want to check");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        Console.WriteLine("Enter the elements");
        for(int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int lar = int.MinValue;
        int slar = int.MinValue;
        
        for(int i = 0; i < size; i++)
        {
            if (arr[i] > lar)
            {
                slar = lar;
                lar = arr[i];
                
            }
            else if(arr[i]>slar && arr[i]<lar)
            {
                slar = arr[i];
                
            }
        }
        Console.WriteLine($"Largest ele is {lar}");
        
        Console.WriteLine($"Second largest ele {slar}");
    
        

    }
}