using System;

namespace ATM
{
    public class Program
    {
        public static decimal Deposit(decimal balance, decimal amount)
        {
            if (amount > 0M) return balance + amount;
            else return balance;
        }

        public static decimal Withdraw(decimal balance, decimal amount)
        {
            if (amount > balance || amount <= 0M) return balance;
            else return balance - amount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
