namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductBuilder builder1 = new ProductBuilder();
            ProductBuilder builder2 = new ProductBuilder();

            Product product1 = builder1.SetName("Toyota Rav4").SetDescription("2018 2.5 4X2").SetPrice(37000).Build();
            Product product2 = builder2.SetName("Toyota Highlander").SetDescription("2018 3.5 4x4").SetPrice(47000).Build();

            product1.Display();
            product2.Display();
        }
    }
}
