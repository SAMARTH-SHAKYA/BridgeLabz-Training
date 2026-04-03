using System;

class AvgPercentMarksSam{
	public static void Main(string[] args){
		string name = "Sam";
		float mathMarks = 94f;
		float chemistryMarks = 96f;
		float physicsMarks = 95f;
		float avg = ((mathMarks + chemistryMarks + physicsMarks)/3);
		Console.WriteLine($"{name}’s average mark in PCM is {avg}");
	}
}