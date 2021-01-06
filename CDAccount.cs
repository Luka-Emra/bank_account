using System;
using System.Collections.Generic;
using System.Text;

// Luka Emrashvili   ID: 823 355 800

namespace Assignment3
{
    public class CDAccount : SavingsAccount  // CDAccount is derived from SavingsAccount class
    {
        private DateTime Maturity { get; set; }   // auto-implemented property for maturity date

        public CDAccount(string accNum, decimal interestRate, decimal accBalance, DateTime maturity)
            : base(accNum, interestRate, accBalance)  // invoke base class's constructor
        {
            Maturity = maturity;
        }

        public override string ToString() =>       // override ToString() method to print the account data
            $"Account Number: {AccNum}\n" +
            $"Interest Rate: {InterestRate:F2}\n" +
            $"Account Balance: {AccBalance:C}\n" +
            $"Account Maturity Date: {Maturity.ToShortDateString()}";
    }
}
