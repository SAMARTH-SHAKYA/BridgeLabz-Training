using System;
class AreaOfTriangle{
	public static void Main(string[] args){
		
		double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
		double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
			
		double areaInCm = 0.5 * baseOfTriangle * heightOfTriangle;
	
		
		double baseOfTriangleInches = baseOfTriangle/2.54;
		double heightOfTriangleINches = heightOfTriangle/2.54;
		
		double areaInches = 0.5 * baseOfTriangleInches * heightOfTriangleINches;
		
	
		double areaFeet = (int)(areaInches/144);
		double finalAreaInches = areaInches%144;
		
		Console.WriteLine($"Your Area in cm square is {areaInCm} while in feet is {areaFeet} and inches is {finalAreaInches}");
	}
}