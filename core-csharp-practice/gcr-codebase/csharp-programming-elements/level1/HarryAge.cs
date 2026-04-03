using System;
class HarryAge{
	public static void Main(string[] args){
		string name = "Harry";
		int birthYear = 2000;
		int currentYear = 2024;
		int age = currentYear - birthYear;
		Console.WriteLine($"{name}'s age in {currentYear} is {age}"); 
	}
}