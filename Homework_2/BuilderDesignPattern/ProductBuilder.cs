namespace BuilderDesignPattern
{
    public class ProductBuilder
    {
        private Product _product = new Product();

        public ProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public ProductBuilder SetDescription(string description)
        {
            _product.Description = description;
            return this;
        }
        public ProductBuilder SetPrice(decimal price)
        {
            _product.Price = price;
            return this;
        }

        public Product Build()
        {
            return _product;
        }
    }
}
