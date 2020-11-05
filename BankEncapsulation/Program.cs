using System;
using System.Diagnostics.CodeAnalysis;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);

            Console.WriteLine($"Thanks, have a great day! Your balance is now {account.GetBalance()}");
            
        }
    }
}
