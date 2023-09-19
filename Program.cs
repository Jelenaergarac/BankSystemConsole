namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount bankAccount = new BankAccount("123456789", "Marko Markovic", 1000.00);
            SavingsAccount savingsAccount = new SavingsAccount("5948484", "Petar Petrovic", 1500.00, 3.0);

            Console.WriteLine("Bank Account Information:");
            bankAccount.DisplayAccountInfo();
            Console.WriteLine("Savings Account Information:");
            savingsAccount.DisplayAccountInfo();

            Console.WriteLine("Enter the deposit amount for Bank Account:");
            double depositAmount = double.Parse(Console.ReadLine());
            bankAccount.Deposit(depositAmount);

            Console.WriteLine("Enter the deposit amount for savings Account:");
            double depositAmount2 = double.Parse(Console.ReadLine());
            savingsAccount.Deposit(depositAmount2);

            Console.WriteLine("Updated Bank Account Information:");
            bankAccount.DisplayAccountInfo();

            Console.WriteLine("Updated Savings Account Information: ");
            savingsAccount.DisplayAccountInfo();

            Console.WriteLine("Enter the withdrawal amount for Bank Account:");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            bankAccount.Withdraw(withdrawalAmount);

            Console.WriteLine("Updated Bank Account Information after Withdraw:");
            bankAccount.DisplayAccountInfo();

            Console.ReadLine();



        }
    }
}