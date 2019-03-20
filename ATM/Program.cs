using System;

namespace ATM
{
    public class Program
    {
        /// <summary>
        /// Adds an amount of money to the users balance.
        /// </summary>
        /// <param name="balance">The users balance.</param>
        /// <param name="amount">The amount of money to add to the balance.</param>
        /// <returns>The users updated balance.</returns>
        public static decimal Deposit(decimal balance, decimal amount)
        {
            if (amount >= 0M) return balance + decimal.Floor(amount * 100) / 100;
            else throw new Exception("You can't deposit a negative amount!");
        }

        /// <summary>
        /// Subtracts an amount of money from the users balance.
        /// </summary>
        /// <param name="balance">The users balance.</param>
        /// <param name="amount">The amount of money to subtract from the balance.</param>
        /// <returns>The users updated balance.</returns>
        public static decimal Withdraw(decimal balance, decimal amount)
        {
            if (amount < 0) throw new Exception("You can't withdraw a negative amount!");
            if (amount > balance) throw new Exception("You can't withdraw more money than you have!");
            else return balance - decimal.Floor(amount * 100) / 100;
        }

        /// <summary>
        /// Clears the console and displays on-screen instructions.
        /// </summary>
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

        /// <summary>
        /// Asks the user if they want to perform another transaction.
        /// </summary>
        /// <returns>true if the user enters y, false if the user enters f.</returns>
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

        /// <summary>
        /// Gets the deposit amount from user input, and performs the deposit.
        /// </summary>
        /// <param name="balance">The users balance.</param>
        /// <returns>The users updated balance.</returns>
        static decimal HandleDeposit(decimal balance)
        {
            decimal amount;
            do
            {
                Console.Write("Please enter an amount to deposit: $");
            } while (!decimal.TryParse(Console.ReadLine(), out amount));
            try
            {
                balance = Deposit(balance, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction completed.");
            }
            return balance;
        }

        /// <summary>
        /// Gets the withdrawal amount from user input, and performs the withdrawal.
        /// </summary>
        /// <param name="balance">The users balance.</param>
        /// <returns>The users updated balance.</returns>
        static decimal HandleWithdraw(decimal balance)
        {
            decimal amount;
            do
            {
                Console.Write("Please enter an amount to withdraw: $");
            } while (!decimal.TryParse(Console.ReadLine(), out amount));
            try
            {
                balance = Withdraw(balance, amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction completed.");
            }
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
                        Console.WriteLine($"Your current balance is ${balance}");
                        run = AnotherTransaction();
                        break;
                    case "2":
                        balance = HandleDeposit(balance);
                        run = AnotherTransaction();
                        break;
                    case "3":
                        balance = HandleWithdraw(balance);
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
