using System.Numerics;

namespace CustomTypeConversions
{
    public class Coordinate
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Coordinate(double x, double y)
        { _x = x; _y = y; }

        public override string ToString()
        {
            return new string($"{X} {Y}");
        }

        public static implicit operator Vector(Coordinate c)
        {
            return new Vector(new Coordinate(0, 0), c);
        }
    }
}
