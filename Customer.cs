using System;
using System.Collections.Generic;
using System.Text;

namespace ToluBankingApp
{
   public class Customer
    {
        public string CustomerId { get; }
        public string Name { get; } //auto-implemented read-only properties. Assigned once in the constructor and never changed
        public List<Account> Accounts { get; }//property with a list of (Account) objects. get with no set present so another list can not be sustituted. However doesn't stop the List being modified.
        public Customer(string customerId, string name) //constructor
        { 
            CustomerId = customerId;
            Name = name;
            Accounts = new List<Account>();
        }

        public void AddAccount(Account account)//method
        {
            Accounts.Add(account);
        }
    }
}
