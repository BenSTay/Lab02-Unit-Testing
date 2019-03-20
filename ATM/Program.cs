using System;

namespace ATM
{
    public class Program
    {
        public static decimal Deposit(decimal balance, decimal amount)
        {
            if (amount > 0M) return balance + decimal.Floor(amount * 100)/100;
            else return balance;
        }

        public static decimal Withdraw(decimal balance, decimal amount)
        {
            if (amount > balance || amount <= 0M) return balance;
            else return balance - amount;
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the bank app!\n");
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit\n");
            Console.Write("> ");
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
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        run = false;
                        break;
                }
            } while (run);
        }
    }
}
