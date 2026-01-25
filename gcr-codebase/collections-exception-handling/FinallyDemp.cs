using System;

class FinallyDemo
{
  static void Main()
  {
    try
    {
      Console.Write("Enter first number: ");
      int num1 = int.Parse(Console.ReadLine());

      Console.Write("Enter second number: ");
      int num2 = int.Parse(Console.ReadLine());

      int result = num1 / num2;
      Console.WriteLine("Result: " + result);
    }
    catch (DivideByZeroException)
    {
      Console.WriteLine("Error: Division by zero is not allowed.");
    }
    finally
    {
      Console.WriteLine("Operation completed");
    }
  }
}
