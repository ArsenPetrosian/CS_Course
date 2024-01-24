public delegate double DiscountCalculator(double totalAmount);

public class DiscountDelegates
{
    public static double RegularCustomerDiscount(double totalAmount)
    {
        double discountPercentage = 10;
        return totalAmount - (totalAmount * discountPercentage / 100);
    }

    public static double VIPCustomerDiscount(double totalAmount)
    {
        double discountPercentage = 20;
        return totalAmount - (totalAmount * discountPercentage / 100);
    }

    public static double SaleDiscount(double totalAmount)
    {
        double discountPercentage = 15;
        return totalAmount - (totalAmount * discountPercentage / 100);
    }

    static void Main()
    {
        DiscountCalculator discountDelegate;

        discountDelegate = RegularCustomerDiscount;

        ApplyDiscount("Regular Customer", 100.0, discountDelegate);

        discountDelegate = VIPCustomerDiscount;

        ApplyDiscount("VIP Customer", 100.0, discountDelegate);

        discountDelegate = SaleDiscount;

        ApplyDiscount("Sale", 100.0, discountDelegate);
    }

    static void ApplyDiscount(string customerType, double totalAmount, DiscountCalculator discountDelegate)
    {
        double discountedAmount = discountDelegate(totalAmount);

        Console.WriteLine($"{customerType} - Original Amount: ${totalAmount}, Discounted Amount: ${discountedAmount}");
    }
}
