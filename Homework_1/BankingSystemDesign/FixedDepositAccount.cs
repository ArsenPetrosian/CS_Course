namespace BankingSystemDesign
{
    public class FixedDepositAccount : IAccount
    {
        private decimal balance;

        public FixedDepositAccount()
        {
            balance = 0;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Console.WriteLine("Withdrawal is not allowed until maturity!");
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Fixed Deposit Account - Balance: $" + balance);
        }
    }
}
