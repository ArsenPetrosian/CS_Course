namespace BankingSystemDesign
{
    internal class Program
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
}
