using System;

namespace Bankomat
{
    public class BankAccount
    {
        private readonly string userName;
        private double balance;

        public BankAccount(string userName, double balance)
        {
            this.userName = userName;
            this.balance = balance;
        }

        public void TakeMoneyFromBalance(double amount)
        {
            if(amount > balance)
            {
                Console.WriteLine(userName + " ballance is less than amount! Your balance is: " + balance);
            }
            else if(amount < 0)
            {
                Console.WriteLine(userName + " can't take less than 0!");              
            }
            else
            {
                balance -= amount;
                Console.WriteLine(userName + " took: " + amount + " and balance is: " + balance);
            }
        }

        public void AddMoneyToBallance(double amount)
        {
            if(amount < 0)
            {
                Console.WriteLine(userName + " can't add less than 0!");
            }
            else
            {
                balance += amount;
                Console.WriteLine(userName + " add to your balance: " + amount + " and now its: " + balance);
            }
        }

        public double Balance()
        {
            if (balance.Equals(""))
            {
                Console.WriteLine("Null balance");
                return 0;
            }
            else
            {
                return balance;
            }
        }

        public static void Main()
        {
            BankAccount user1 = new BankAccount("Rafał", 5000);
            user1.TakeMoneyFromBalance(328.5);
            user1.AddMoneyToBallance(328.5);
            user1.TakeMoneyFromBalance(5223);
            user1.AddMoneyToBallance(100);
            user1.TakeMoneyFromBalance(200);
        }
    }
}