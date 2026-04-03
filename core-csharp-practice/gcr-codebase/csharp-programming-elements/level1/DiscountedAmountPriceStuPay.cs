using System;
class DiscountedAmountPriceStuPay{
	public static void Main(string[] args){
		int fee = 125000;
		int discountPercent = 10;
		int discount = (fee * discountPercent) / 100;
		int feeToPay = fee - discount;
		
		Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {feeToPay}");
		
	}
}