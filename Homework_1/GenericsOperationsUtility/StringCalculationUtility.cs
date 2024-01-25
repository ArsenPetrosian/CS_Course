namespace GenericsOperationsUtility
{
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
