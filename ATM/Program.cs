using System;

namespace ATM
{
    public class Program
    {
        public static Decimal Deposit(decimal balance, decimal amount)
        {
            if (amount > 0M) return balance + amount;
            else return balance;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
