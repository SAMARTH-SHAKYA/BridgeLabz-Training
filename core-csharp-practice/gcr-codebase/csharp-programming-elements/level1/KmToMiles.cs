using System;
class KmToMiles{
	public static void Main(string[] args){
		float distanceInKm = 10.8f;
		float distanceInMiles = distanceInKm * 0.621f;
		Console.WriteLine($"The distance {distanceInKm} km in miles is {distanceInMiles}");
	}
}