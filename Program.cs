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

            Bank bank = new Bank();
            Customer tee = new Customer ("C001", "Tee");
            bank.AddCustomer(tee);

            Account acc1 = new Account("12345678", "Tee");
            bank.OpenAccount(tee, acc1);

            Account found = bank.FindAccountByNumber("12345678");
            Console.WriteLine(found.Owner);

        }

    }
}
