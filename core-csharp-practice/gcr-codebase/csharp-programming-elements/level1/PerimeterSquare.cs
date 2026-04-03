using System;
class PerimeterSquare{
	public static void Main(string[] args){
		int length = Convert.ToInt32(Console.ReadLine());
		
		int perimeter = 4*length;
		
		Console.WriteLine($"The length of the side is {length} whose perimeter is {perimeter}");
		
	}
}