namespace GenericsOperationsUtility
{
    public class NumericCalculationUtility : ICalculationUtility<int>
    {
        public int Add(int l, int r)
        {
            return l + r;
        }

        public int Sub(int l, int r)
        {
            return l - r;
        }

        public int Mul(int l, int r)
        {
            return l * r;
        }

        public int Div(int l, int r)
        {
            if (r != 0)
            {
                return l / r;
            }
            else
            {
                throw new ArgumentException("Cannot divide a number by zero.");
            }
        }

        public void QuotientRemainder(int l, int r, out int quotient, out int remainder)
        {
            quotient = l / r;
            remainder = l % r;
        }
    }
}
