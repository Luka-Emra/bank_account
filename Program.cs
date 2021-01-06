using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Luka Emrashvili   ID: 823 355 800

namespace Assignment3
{
    class Program
    {
        static void Main()
        {
 
            List < CDAccount > CDAccounts = new List<CDAccount>();    // List to store CD accounts (objects)

            Console.Write("\nDo you want to create a new CD Account? (Type Y or N): ");    
            var answer = Console.ReadLine()[0];

            while (String.Equals(answer, 'Y') || String.Equals(answer, 'y'))    // if user enters Y or y prompt user to enter data below.
            {
                Console.Write("\nEnter Account Number: ");  
                var accNum = Console.ReadLine();
                Console.Write("\nEnter Interest rate(e.g. 0.04): ");    
                var interestRate = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nEnter Account Balance: ");               
                var accBalance = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\nEnter Account Maturity date(e.g. 10/23/2020): ");  
                var maturity = Convert.ToDateTime(Console.ReadLine());

                CDAccount Account = new CDAccount(accNum, interestRate, accBalance, maturity);   // create CDAccount object and pass user entered data as arguments

                Console.Write("\nDo you want to deposit money to your account? (Type Y or N): ");   
                var answer1 = Console.ReadLine()[0];

                if (String.Equals(answer1, 'Y') || String.Equals(answer1, 'y'))        
                {
                    Console.Write("\nPlease enter the amount: ");
                    Account.Deposit(Convert.ToDecimal(Console.ReadLine()));          // Deposit money to the account using Deposit() method
                }

                Console.Write("\nDo you want to withdraw money from your account? (Type Y or N): ");
                var answer2 = Console.ReadLine()[0];

                if (String.Equals(answer2, 'Y') || String.Equals(answer2, 'y'))
                {
                    Console.Write("\nPlease enter the amount: ");           // Withdraw money from the account using Withdraw() method
                    Account.Withdraw(Convert.ToDecimal(Console.ReadLine()));
                }

                CDAccounts.Add(Account);           // add object to the list of CD accounts
                Console.Write("\nDo you want to create a new CD Account? (Type Y or N): ");      // ask again 
                answer = Console.ReadLine()[0];
            }

            Console.WriteLine("\n");

            CDAccounts.Sort();          // Sorts objects using overriden CompareTo() method
            foreach(CDAccount account in CDAccounts)       // traverse through the list
            {
                Console.WriteLine(account + "\n");   // Print data using overriden ToString() method
            }
        }
    }
}
    