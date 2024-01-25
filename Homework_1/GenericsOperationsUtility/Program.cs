namespace GenericsOperationsUtility
{
    internal class Program
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
}
