using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text; 

namespace csharpcode;

class Program
{
    static void Main(string[] args)
    {
        Account Acc1 = new Account();
        
        // Added prompts so the user knows what to type
        Console.WriteLine("Enter Name:");
        Acc1.NameHolder = Console.ReadLine();
        
        Console.WriteLine("Enter ID:");
        Acc1.id = int.Parse(Console.ReadLine());

        int choice;
        do
        {
            Console.WriteLine("=== Welcome to the Egyptian Bank!");
            Console.WriteLine("choose what yoou want: ");
            Console.WriteLine("1. Display Data  ");
            Console.WriteLine("2. Deposit ");
            Console.WriteLine("3. Withdraw ");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter ur choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Acc1.display(); 
                    break;
                case 2:
                    Console.Write("Enter the amount you wanna add\t");
                    // FIXED: Changed int.Parse to decimal.Parse to match your Struct
                    Acc1.AddedAmount = decimal.Parse(Console.ReadLine());
                    Acc1.Deposit(Acc1.AddedAmount); 
                    break;
                case 3:
                    Console.Write("Enter the amount u wanna withdraw\t");
                    // FIXED: Changed int.Parse to decimal.Parse to match your Struct
                    Acc1.WithdrawnAmount = decimal.Parse(Console.ReadLine());
                    Acc1.Withdraw(Acc1.WithdrawnAmount); 
                    break;

                case 4:
                    Console.WriteLine("Exiting..."); 
                    break;
            }
        } while (choice != 4);
    }
} // End of Class Program

// FIXED: Moved Struct OUTSIDE of the Main method
struct Account
{
    // properties
    public string NameHolder { get; set; }
    public int id { get; set; }
    public decimal Balance { get; set; }
    public decimal AddedAmount { get; set; }
    public decimal WithdrawnAmount { get; set; }

    // methods 
    public void Deposit(decimal amount)
    {
        if (amount < 0) Console.WriteLine("Invalid Input");
        else
        {
            Balance += amount;
        }
        Console.WriteLine($"The Updated Balance is {Balance} at {DateTime.Now}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance) Console.WriteLine("There is not enough money to withdraw !");
        else
        {
            Balance -= amount;
        }
        Console.WriteLine($"The withdrwan amount is {amount} at {DateTime.Now}");
        Console.WriteLine($"The updated Balance is {Balance}");
    }

    public void display()
    {
        Console.WriteLine($"Holder Name: {NameHolder}");
        Console.WriteLine($"Account ID: {id}");
        Console.WriteLine($"The current balance: {Balance}");
    }
}
