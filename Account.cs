using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ToluBankingApp
{
    public class Account
    {
        public string AccountNumber { get; }//Property
        public string Owner { get; }//Property
        public decimal Balance { get; private set; }//Property
        private List<string> _transactionLog;
        /* Declare a private List<string> field called _transactionLog to record a simple text entry for every deposit/withdrawal.*/


        public Account(string accountNumber, string owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = 0;

            _transactionLog = new List<string>();
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException(
                $"Deposit amount must be greater than zero. Received: {amount}");// Validate the amount
            }

            Balance += amount ;//if valid increase Balance by amount
            _transactionLog.Add($"Deposited {amount} on {DateTime.Now}"); //Add entry to _transactionLog describing the deposit

        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0) {

                throw new ArgumentException(
                    $"Withdrawal amount must be greater than zero. Attempted: {amount}");
            }
      
            if (amount > Balance) {
                throw new ArgumentException(
                   $"Withdrawal amount exceeds the account balance. Attempted: {amount}" );
            }
            Balance -= amount ;//if valid decrease Balance by amount
            _transactionLog.Add($"Withdrew {amount} on {DateTime.Now}");
        }
        public void PrintTransactionHistory()
        {
            if (_transactionLog.Count == 0)

            {
                Console.WriteLine("No transactions yet.");
            }
            else
                foreach (string entry in _transactionLog)
                {
                    Console.WriteLine(entry);
                }
        }
    }
}
       







