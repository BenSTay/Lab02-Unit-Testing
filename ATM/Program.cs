using System;

namespace ATM
{
    public class Program
    {
        public static decimal Deposit(decimal balance, decimal amount)
        {
            if (amount > 0M) return balance + decimal.Floor(amount * 100) / 100;
            else return balance;
        }

        public static decimal Withdraw(decimal balance, decimal amount)
        {
            if (amount > balance || amount <= 0M) return balance;
            else return balance - decimal.Floor(amount * 100) / 100;
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the bank app!\n");
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Cancel\n");
            Console.Write("> ");
        }

        static bool AnotherTransaction()
        {
            string input;
            do
            {
                Console.Write("Would you like another transaction? (y/n): ");
                input = Console.ReadLine().ToLower();
            } while (input != "y" && input != "n");
            return input == "y";
        }

        static decimal HandleDeposit(decimal balance)
        {
            decimal amount;
            do
            {
                Console.Write("Please enter an amount to deposit: $");
            } while (!decimal.TryParse(Console.ReadLine(), out amount));
            balance = Deposit(balance, amount);
            return balance;
        }

        static void Main(string[] args)
        {
            bool run = true;
            decimal balance = 5000M;
            string input;
            do
            {
                DisplayMenu();
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        
                        run = AnotherTransaction();
                        break;
                    case "2":
                        balance = HandleDeposit(balance);
                        run = AnotherTransaction();
                        break;
                    case "3":
                        run = AnotherTransaction();
                        break;
                    case "4":
                        run = false;
                        break;
                }
            } while (run);
        }
    }
}
