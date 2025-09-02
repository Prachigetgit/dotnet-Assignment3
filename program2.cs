using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class program2
    {
        public string accountNumber;
        public string accountHolderName;
        public double balance;
        public program2(string accountNumber, string accountHolderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
            } else if(amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Withdrawal amouhnt must  be positive");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder Name: {accountHolderName}");
            Console.WriteLine($"Balance: {balance}");
        }

        public static void Main1(string[] args)
        {
            program2 account = new program2("123456789", "John Doe", 1000.0);
            account.DisplayAccountDetails();
            account.Deposit(500.0);
            account.Withdraw(200.0);
            account.Withdraw(1500.0); // Attempt to withdraw more than balance
            account.DisplayAccountDetails();
        }

    }
}
