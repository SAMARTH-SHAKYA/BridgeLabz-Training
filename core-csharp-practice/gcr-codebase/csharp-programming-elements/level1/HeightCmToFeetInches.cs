using System;
class HeightCmToFeetInches{
	public static void Main(string[] args){
		double heightCm = Convert.ToDouble(Console.ReadLine());
		
		double totalInches = heightCm/2.54;
		int feet = (int)(totalInches/12);
		double inches = totalInches%12;
		
		Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet} and inches is {inches}");
		
	}
}