using System;
class CalculateProfitLoss{
	public static void Main(string[] args){
		float cp = 129;
		float sp = 191;
		
		float profit = sp - cp;
		float profitPercentage = (profit/cp) * 100f;
		
		Console.WriteLine($"The Cost Price is INR {cp} and Selling Price is INR {sp}");
		Console.WriteLine($"The Profit is INR {profit} and the Profit Percentage is {profitPercentage}");
	} 
}