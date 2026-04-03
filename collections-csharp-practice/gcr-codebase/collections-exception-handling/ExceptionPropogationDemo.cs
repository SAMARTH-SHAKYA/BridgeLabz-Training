using System;

class ExceptionPropagationDemo
{
  static void Method1()
  {
    int result = 10 / 0;   // Throws ArithmeticException
  }

  static void Method2()
  {
    Method1();             // No handling here
  }

  static void Main()
  {
    try
    {
      Method2();         // Exception propagates here
    }
    catch (ArithmeticException)
    {
      Console.WriteLine("Handled exception in Main");
    }
  }
}
