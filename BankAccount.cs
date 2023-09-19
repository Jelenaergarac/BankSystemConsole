using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class BankAccount
    {
        private string accountNumber;
        private string accountHolder;
        protected double balance;


        public BankAccount(string accountNumber, string accountHolder, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = initialBalance;

        }

        public virtual void Deposit(double amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit: {amount}, New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }
        public void Withdraw(double amount)
        {
            if(amount >0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal: {amount}, New Balance: {balance}");

            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");

            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Balance:{balance}");
        }
    }
}
