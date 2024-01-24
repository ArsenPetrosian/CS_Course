using BuilderDesignPattern;

namespace Integration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart()
            .AddToCart(new Product { Name = "Chair", Price = 49.99m, Description = "Comfortable chair" })
            .AddToCart(new Product { Name = "Table", Price = 99.99m, Description = "Loft table" });

            OrderBuilder orderBuilder = shoppingCart.Checkout(DiscountDelegates.SaleDiscount);

            Order order = orderBuilder.Build();

            Console.WriteLine("Order Details:");
            foreach (var product in order.Products)
            {
                product.Display();
            }
        }
    }
}
