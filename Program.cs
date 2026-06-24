namespace ToluBankingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account("12345678", "Tee");
            myAccount.Deposit(100);
            myAccount.Withdraw(30);
            myAccount.PrintTransactionHistory();
        }
    }
}
