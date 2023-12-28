namespace Homework_1
{
    internal class BankingSystemDesign
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(500);
            savingsAccount.DisplayDetails();

            CheckingAccount checkingAccount = new CheckingAccount(0, 400);
            checkingAccount.Deposit(2000);
            checkingAccount.Withdraw(2500); // Exceeds overdraft limit
            checkingAccount.DisplayDetails();

            FixedDepositAccount fixedDepositAccount = new FixedDepositAccount();
            fixedDepositAccount.Deposit(5000);
            fixedDepositAccount.Withdraw(1000); // Withdrawal not allowed until maturity
            fixedDepositAccount.DisplayDetails();
        }
    }

    interface IAccount
    {
        decimal GetBalance();
        void DisplayDetails();
    }

    public class SavingsAccount: IAccount
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
            if(amount <= balance)
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

    public class CheckingAccount: IAccount
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