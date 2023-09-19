using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class SavingsAccount: BankAccount
    {
        private double interestRate;

        public SavingsAccount(string accountNumber, string accountHolder, double interestRate, double initialBalance): base(accountNumber,accountHolder, initialBalance)
        {
            this.interestRate = interestRate;
        }
        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            double interest = amount * (interestRate / 100);
            Console.WriteLine($"Interest Earned: {interest}, New Balance: {balance}");

        }
    }
}
