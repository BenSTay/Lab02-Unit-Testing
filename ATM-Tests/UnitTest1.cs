using System;
using Xunit;

namespace ATM_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanDeposit()
        {
            decimal balance = 0M;
            balance = ATM.Program.Deposit(balance, 500M);
            Assert.Equal(500M, balance);
        }

        [Fact]
        public void CantDepositNegative()
        {
            decimal balance = 0M;
            Assert.Throws<Exception>(() => ATM.Program.Deposit(balance, -500M));
        }

        [Fact]
        public void CanWithdraw()
        {
            decimal balance = 500M;
            balance = ATM.Program.Withdraw(balance, 500M);
            Assert.Equal(0M, balance);
        }

        [Fact]
        public void CantOverdraw()
        {
            decimal balance = 0M;
            Assert.Throws<Exception>(() => ATM.Program.Withdraw(balance, 500M));
        }

        [Fact]
        public void CantWithdrawNegative()
        {
            decimal balance = 0M;
            Assert.Throws<Exception>(() => ATM.Program.Withdraw(balance, -500M));
        }

        [Fact]
        public void DepositIgnoresSubPennies()
        {
            decimal balance = 0M;
            balance = ATM.Program.Deposit(balance, 123.456789M);
            Assert.Equal(123.45M, balance);
        }

        [Fact]
        public void WithdrawIgnoresSubPennies()
        {
            decimal balance = 500M;
            balance = ATM.Program.Withdraw(balance, 123.456789M);
            Assert.Equal(376.55M, balance);
        }
    }
}
