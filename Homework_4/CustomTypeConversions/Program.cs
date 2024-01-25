namespace CustomTypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coordinate coordinate = new Coordinate(10.5, 27.5);
            Vector vector = coordinate;
            Console.WriteLine(vector.ToString());

            coordinate = (Coordinate)vector;
            Console.WriteLine(coordinate.ToString());
        }
    }
}
