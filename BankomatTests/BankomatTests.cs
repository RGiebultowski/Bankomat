using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bankomat;

namespace BankomatTests
{
    [TestClass]
    public class BankomatTests
    {
        [TestMethod]
        public void TakeMoneyFromBalanceTest()
        {
            double baseBalance = 10;
            double amount = 5;
            double expected = 5;

            BankAccount testUser1 = new BankAccount("TestUser1", baseBalance);
            testUser1.TakeMoneyFromBalance(amount);

            double actualBalance = testUser1.Balance();
            Assert.AreEqual(expected, actualBalance,0.0001, "Acount calculation is bad.");
        }

        [TestMethod]
        public void AddMoneyToBalanceTest()
        {
            double baseBalance = 10;
            double amount = 10;
            double expected = 20;

            BankAccount testUser2 = new BankAccount("TestUser2", baseBalance);
            testUser2.AddMoneyToBallance(amount);

            double actualBalance = testUser2.Balance();
            Assert.AreEqual(expected, actualBalance);
        }
    }
}
