using System;

namespace ATM
{
    public class Program
    {
        public static Decimal Deposit(decimal balance, decimal amount)
        {
            return balance + amount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
