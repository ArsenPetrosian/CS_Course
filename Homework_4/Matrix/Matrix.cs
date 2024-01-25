namespace Matrix
{
    public class Matrix
    {
        private int[,] _data;
        private int _rows;
        private int _columns;

        public int Rows => _rows;
        public int Columns => _columns;

        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _data = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get
            {
                if (IsValidIndex(row, column))
                {
                    return _data[row, column];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of bounds");
                }
            }
            set
            {
                if (IsValidIndex(row, column))
                {
                    _data[row, column] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of bounds");
                }
            }
        }

        private bool IsValidIndex(int row, int column)
        {
            return row >= 0 && row < _rows && column >= 0 && column < _columns;
        }
    }

}
