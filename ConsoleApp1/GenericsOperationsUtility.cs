namespace ConsoleApp1
{
    internal class GenericsOperationsUtility
    {
        static void Main(string[] args)
        {
            ICalculationUtility<int> numericCalculator = new NumericCalculationUtility();
            int sum = numericCalculator.Add(5, 3);
            int difference = numericCalculator.Sub(8, 2);
            int product = numericCalculator.Mul(4, 6);
            int quotient = numericCalculator.Div(10, 2);
            int remainder;
            numericCalculator.QuotientRemainder(15, 4, out quotient, out remainder);

            Console.WriteLine($"Numeric Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");

            // String calculations
            ICalculationUtility<string> stringCalculator = new StringCalculationUtility();
            string concatenation = stringCalculator.Add("Hello", "World");
            Console.WriteLine($"String Concatenation: {concatenation}");
        }
    }

    public interface ICalculationUtility<T>
    {
        T Add(T l, T r);
        T Sub(T l, T r);
        T Mul(T l, T r);
        T Div(T l, T r);
        void QuotientRemainder(T l, T r, out T quotient, out T remainder);
    }

    // Numeric implementation of the generic interface
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

    // String implementation of the generic interface
    public class StringCalculationUtility : ICalculationUtility<string>
    {
        public string Add(string l, string r)
        {
            return l + r;
        }

        public string Sub(string l, string r)
        {
            Console.WriteLine("Subtraction is not supported for strings.");
            return "";
        }

        public string Mul(string l, string r)
        {
            Console.WriteLine("Multiplication is not supported for strings.");
            return "";
        }

        public string Div(string l, string r)
        {
            Console.WriteLine("Division is not supported for strings.");
            return "";
        }

        public void QuotientRemainder(string l, string r, out string quotient, out string remainder)
        {
            Console.WriteLine("Quotient and remainder are not supported for strings.");
            quotient = "";
            remainder = "";
        }
    }
}
