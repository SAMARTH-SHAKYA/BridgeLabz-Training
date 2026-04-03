using System;

class NestedTryCatchDemo
{
  static void Main()
  {
    int[] arr = { 10, 20, 30, 40 };

    Console.Write("Enter index: ");
    int index = int.Parse(Console.ReadLine());

    Console.Write("Enter divisor: ");
    int divisor = int.Parse(Console.ReadLine());

    try
    {
      try
      {
        int result = arr[index] / divisor;
        Console.WriteLine("Result: " + result);
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("Cannot divide by zero!");
      }
    }
    catch (IndexOutOfRangeException)
    {
      Console.WriteLine("Invalid array index!");
    }
  }
}
