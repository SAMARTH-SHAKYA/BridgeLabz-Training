using System;
class PenDistribution{
	public static void Main(string[] args){
		int pens = 14;
		int students = 3;
		
		int penEachStuGet = pens/students;
		int penNonDistributed = pens%students;
		
		Console.WriteLine($"The Pen Per Student is {penEachStuGet} and the remaining pen not distributed is {penNonDistributed}");
	}
}