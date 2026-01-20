using System;
public static class DiscountUtility
{
    public static void ApplyDiscount<T>(T product, double percentage) where T : ProductBase
    {
        double discountAmount = product.Price * (percentage / 100);
        product.Price -= discountAmount;
    }
}
