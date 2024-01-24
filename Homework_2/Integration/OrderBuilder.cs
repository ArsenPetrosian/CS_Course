using BuilderDesignPattern;

namespace Integration
{
    public class OrderBuilder
    {
        private Order _order = new();

        public OrderBuilder AddProduct(Product product)
        {
            _order.Products?.Add(product);
            return this;
        }

        public Order Build()
        {
            return _order;
        }
    }
}
