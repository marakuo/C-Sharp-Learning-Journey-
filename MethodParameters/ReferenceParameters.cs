using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text; // for string builder 



namespace malak
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the old password: ");
            string oldpass = Console.ReadLine();
            Console.WriteLine();
            ChangePass(ref oldpass);
            




        }
       static void ChangePass(ref string pass)
        {
            Console.WriteLine("Enter the new password: ");
            string newpass = Console.ReadLine();
            pass = newpass;
            Console.WriteLine($"The new password is {newpass}");


        }


    }


    }



