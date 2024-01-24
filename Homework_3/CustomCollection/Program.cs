namespace CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<int> collection = new CustomCollection<int>();

            for (int i = 0; i < 10; ++i)
                collection.Add(i);

            collection.Remove(0);
            collection.Remove(8);

            if (collection.Contains(1))
                Console.WriteLine("Contains!");

            if (!collection.Contains(11))
                Console.WriteLine("Collection doesn't contain 11");

            Console.WriteLine($"Collection has {collection.Count} elements");

            foreach (int i in collection)
                Console.WriteLine(i);

            Console.WriteLine(collection[1]);
            collection[3] = 21;
            Console.WriteLine(collection[3]);
        }
    }
}
