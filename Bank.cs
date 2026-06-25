using System;
using System.Collections.Generic;
using System.Text;

namespace ToluBankingApp
{
    public class Bank
    {

        public List<Customer> Customers { get; }//property, read only list of all customers
        private Dictionary<string, Account> _accountsByNumber;//field, private dictionary to look up account number

        public Bank()
        { 
            Customers = new List<Customer>();
            _accountsByNumber = new Dictionary<string, Account>();
        }//Constructor, runs once when 'new Bank()' is called

        public void AddCustomer(Customer customer)
        
        { 
        Customers.Add(customer);
        }//Method, add a new customer to the bank

        public void OpenAccount(Customer customer, Account account)
        {
            customer.AddAccount(account);
            _accountsByNumber[account.AccountNumber] = account;
        }// Method, opens account and stores it in the lookup dictionary

        public Account FindAccountByNumber(string accountNumber)

        { 
            if (_accountsByNumber.ContainsKey(accountNumber))
            {

                return _accountsByNumber[accountNumber];

            }
            return null;
        }//Method, looks up an account directly by its account number

        public Customer FindCustomerByName(string name)
        {
            foreach (Customer customer in Customers)
            {
                if (customer.Name == name)

                { return customer; }
            }
            return null;
        }//Method searches every customer to find one by name

    }
}
