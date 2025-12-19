using System;
class Calculator{
	public static void Main(string[] args){
		
		double num1 = Convert.ToDouble(Console.ReadLine());
		double num2 = Convert.ToDouble(Console.ReadLine());
		
		double addtion = num1+num2;
		double subtraction = num1 - num2;
		double multiplication = num1*num2;
		double division = num1/num2;
		
		Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {num1} and {num2} is {addtion}, {subtraction}, {multiplication}, and {division}");
		
	}
}