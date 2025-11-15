using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text; // for string builder 



namespace malak
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount MyAccount = new BankAccount();
            MyAccount.BankName = "American Bank";
            MyAccount.BranchName = "Egyptian Branch";
            MyAccount.BranchAddress = "123 El-Naser Streat";
            MyAccount.AccountNumber = "DE017874637";
            MyAccount.AccountCurrancy = "USD";
            MyAccount.Balance = 10000;
           
            static void DisplayData(BankAccount MyAccount)
            {
                Console.WriteLine(MyAccount.BankName);
                Console.WriteLine(MyAccount.BranchName);
                Console.WriteLine(MyAccount.BranchAddress);
                Console.WriteLine(MyAccount.AccountNumber);
                 
            }
            DisplayData(MyAccount);
            MyAccount.Withdraw(250);
            MyAccount.Deposit(250);











        }






    }

// creatng a class 
 class BankAccount
    {
        // variables 
        string bankName;
        string branchName;
        string brachAddress;
        string accountNumber;
        string accountCurrency;
        decimal balance;

        // properties 
        public string BankName
        {
            get { return bankName;  }
            set { bankName = value;  }
        }
        public string BranchName
        {
           get { return branchName; }
           set { branchName = value; }
        }
        public string BranchAddress
        {
           get { return brachAddress; }
            set { brachAddress = value; }
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountCurrancy
        {
            get { return accountCurrency; }
            set { accountCurrency = value; }
        }
       
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        // methods 
        public void Withdraw(decimal amount) {
            decimal newBalance = Balance - amount;
            if(newBalance < 0) Console.WriteLine("Invalid Transaction");
            else
            {
                Console.WriteLine($"Withdrawn amount is {newBalance}");
                Console.WriteLine($"Your new balance for account {AccountNumber} is {newBalance}");
            }
            Console.WriteLine($"Transaction Date is {DateTime.Now}");
            Balance = newBalance;
        
        }

        public void Deposit(decimal amount) {
            decimal newBalance = Balance + amount;
            Console.WriteLine($"The transfered amount is {newBalance}");
            Console.WriteLine($"Your New balance for account {AccountNumber} is {newBalance}");
            Console.WriteLine($"Transaction Date is {DateTime.Now}");
             Balance = newBalance;

        }
        
       
        





    }
}






