using System;
class Handshakes{
	public static void Main(string[] args){
		double n = Convert.ToDouble(Console.ReadLine());
		
		double handshakes = (n*(n-1))/2;
		
		Console.WriteLine($"Total number of handshakes if there are {n} students is {handshakes}");
	}
}