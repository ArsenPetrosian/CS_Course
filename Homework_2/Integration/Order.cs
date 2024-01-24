using BuilderDesignPattern;

namespace Integration
{
    public class Order
    {
        public List<Product>? Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
