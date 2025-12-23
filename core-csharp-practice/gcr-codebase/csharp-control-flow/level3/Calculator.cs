using System;
class Calculator
{
    public static void Main(string[] args)
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        char operation = Console.ReadLine()[0];

        switch (operation)
        {
            case '+':
                Console.WriteLine(num1+num2);
                break;
            
            case '-':
                Console.WriteLine(num1-num2);
                break;
            
            case '*':
                Console.WriteLine(num1*num2);
                break;
            
            case '/':
                Console.WriteLine(num1/num2);
                break;
            
            default: 
                Console.WriteLine("some error occured");
                break;
        }
    }

}