namespace BuilderDesignPattern
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void Display()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}, Description: {Description}");
        }
    }
}
