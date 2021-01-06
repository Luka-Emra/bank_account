using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

// Luka Emrashvili   ID: 823 355 800

namespace Assignment3
{
    public class SavingsAccount : IComparable<SavingsAccount>   // implement Icomparable Interface
    {
        public string AccNum { get; set; }     // auto-implemented property for account number
        private decimal interestRate;         // private instance variables
        private decimal accBalance;

        // constructor 
        public SavingsAccount(string accNum, decimal interestRate, decimal accBalance)
        {
            AccNum = accNum;
            InterestRate = interestRate;
            AccBalance = accBalance;
        }

        public decimal AccBalance    // public Property for validation Account Balance
        {
            get
            {
                return accBalance;
            }
            set
            {
                if (value < 0)      // validate the balance 
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                      value, $"{nameof(AccBalance)} cannot be negative");
                }

                accBalance = value;
            }
        }
        public decimal InterestRate    // public Property for validation Account Balance
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value <= 0 || value >= 1)  // validate if the value entered is between proper interval
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(InterestRate)} must be > 0 and < 1");
                }

                interestRate = value;
            }
        }

        public int CompareTo(SavingsAccount other)     // Override CompareTo() method
        {
            return other.accBalance.CompareTo(this.accBalance);     // sort based on the Balance in Descending order
        }

        public virtual void Deposit(decimal amount)     // Method for Deposit money on account
        {
            if (amount > 0)     // validate if the amount entered is greater than 0
            {
                this.AccBalance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount),
                    amount, $"{nameof(amount)} must be greater than 0");
            }
        }

        public virtual void Withdraw(decimal amount)     // Method to Withdraw money from account
        {
            if (AccBalance - amount >= 0)    // validate that the amount entered is not greater than the balance on account.
            {
                this.AccBalance -= amount;
            }
            else
            {
                Console.Write("Debit amount exceeds the account balance.");
            }
        }
    }
}
