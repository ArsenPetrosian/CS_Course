namespace BankingSystemDesign
{
    public class SavingsAccount : IAccount
    {
        private decimal balance;

        public SavingsAccount()
        {
            balance = 0;
        }
        public SavingsAccount(decimal balance)
        {
            this.balance = balance;
        }
        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient amount!");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Saving Account - Balance: $" + balance);
        }
    }
}
