using BuilderDesignPattern;

namespace Integration
{
    public class ShoppingCart
    {
        private List<Product> _cart = new List<Product>();
        public ShoppingCart AddToCart(Product product)
        {
            _cart.Add(product);
            return this;
        }

        public OrderBuilder Checkout(DiscountCalculator discountCalculator)
        {
            double totalAmount = _cart.Sum(product => (double)product.Price);

            double discountedAmount = discountCalculator(totalAmount);

            OrderBuilder orderBuilder = new OrderBuilder();
            foreach (var product in _cart)
            {
                orderBuilder.AddProduct(product);
            }

            Console.WriteLine($"Total Amount: ${totalAmount}, Discounted Amount: ${discountedAmount}");

            return orderBuilder;
        }
    }
}
