namespace BankingSystemDesign
{
    public class CheckingAccount : IAccount
    {
        private decimal balance;
        private decimal overDraftLimit;

        public CheckingAccount()
        {
            balance = 0;
            overDraftLimit = 0;
        }
        public CheckingAccount(decimal overDraftLimit)
        {
            this.overDraftLimit = overDraftLimit;
        }
        public CheckingAccount(decimal balance, decimal overDraftLimit)
        {
            this.balance = balance;
            this.overDraftLimit = overDraftLimit;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance + overDraftLimit)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("You exceeded overdraft limit!");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Checking Account - Balance: $" + balance + "\nOverDraft Limit: $" + overDraftLimit);
        }
    }
}
