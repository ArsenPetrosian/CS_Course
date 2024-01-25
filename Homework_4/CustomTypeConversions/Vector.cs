namespace CustomTypeConversions
{
    public class Vector
    {
        private Coordinate _start;
        private Coordinate _end;

        public Coordinate Start => _start;
        public Coordinate End => _end;

        public Vector(Coordinate start, Coordinate end)
        {
            _start = start;
            _end = end;
        }
        public override string ToString()
        {
            return new string($"{_start.ToString()}\n{_end.ToString()}");
        }

        public static explicit operator Coordinate(Vector v)
        {
            return new Coordinate(v.Start.X + v.End.X, v.Start.Y + v.End.Y);
        }
    }
}
