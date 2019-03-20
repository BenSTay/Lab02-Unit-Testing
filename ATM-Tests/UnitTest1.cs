using System;
using Xunit;

namespace ATM_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanDeposit()
        {
            decimal balance = 0;
            balance = ATM.Program.Deposit(balance, 500M);
            Assert.Equal(500M, balance);
        }
    }
}
