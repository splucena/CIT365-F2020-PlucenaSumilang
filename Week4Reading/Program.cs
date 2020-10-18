using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Reading
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WindrawFunds(decimal amount);
        decimal GetBalance();
    }

    public class CustomerAccount : IAccount
    {
        private decimal balance = 0;
        public decimal GetBalance()
        {
            return balance;
        }

        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public bool WindrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
    }

    public class BabyAccount : IAccount
    {
        private decimal balance = 0;
        public decimal GetBalance()
        {
            return balance;
        }

        public void PayInFunds(decimal amount)
        {
            balance = balance + amount;
        }

        public bool WindrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            if (balance < amount )
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
    }
    class Program
    {
        const int MAX_CUST = 100;
        static void Main(string[] args)
        {
            
            // Assign an instance of CustomerAccount to IAccount interface
            IAccount account = new CustomerAccount();
            account.PayInFunds(50);
            Console.WriteLine("Balance: " + account.GetBalance());            

            IAccount[] accounts = new IAccount[MAX_CUST];

            accounts[0] = new CustomerAccount();
            accounts[0].PayInFunds(50);
            Console.WriteLine("Balance: " + accounts[0].GetBalance());

            accounts[1] = new BabyAccount();
            accounts[1].PayInFunds(20);
            Console.WriteLine("Balance: " + accounts[1].GetBalance());

            Console.ReadKey();
        }
    }
}
