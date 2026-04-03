using System;
class TotalPrice{
	public static void Main(string[] args){
		
		int unitPrice = Convert.ToInt32(Console.ReadLine());
		
		int quantity = Convert.ToInt32(Console.ReadLine());
		
		int totatlPrice = unitPrice * quantity;
		
		Console.WriteLine($"The total purchase price is INR {totatlPrice} if the quantity {quantity} and unit price is INR {unitPrice}");
		
	}
}