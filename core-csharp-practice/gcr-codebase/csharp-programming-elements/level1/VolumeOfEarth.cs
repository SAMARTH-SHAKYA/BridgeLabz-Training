using System;
class VolumeOfEarth{
	public static void Main(string[] args){
		float radiusInKm = 6378f;
		float radiusInMiles = radiusInKm * 0.621f;
		float volumeForKm = (4/3) * 3.14f * radiusInKm * radiusInKm * radiusInKm;
		float volumeForMiles = (4/3) * 3.14f * radiusInMiles * radiusInMiles * radiusInMiles;
		
		Console.WriteLine($"The volume of earth in cubic kilometers is {volumeForKm} and cubic miles is {volumeForMiles}");
		
		
		
	}
}