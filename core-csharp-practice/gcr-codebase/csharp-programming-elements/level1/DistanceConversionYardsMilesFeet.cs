using System;
class DistanceConversionYardsMilesFeet{
	public static void Main(string[] args){
		double feet = Convert.ToDouble(Console.ReadLine());
		
		double yard = feet/3;
		double mile = feet/1760;
		
		Console.WriteLine($"Your Distance in feet is {feet} while in yards is {yard} and miles is {mile}");
		
	}
}