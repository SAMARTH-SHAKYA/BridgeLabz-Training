using System;
class InputDisAmountPriceStuPay{
	public static void Main(string[] args){
		
		double fee = Convert.ToDouble(Console.ReadLine());
		double discountPercent = Convert.ToDouble(Console.ReadLine());
		double discount = (fee * discountPercent) / 100;
		double feeToPay = fee - discount;
		
		Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {feeToPay}");
	}
}





