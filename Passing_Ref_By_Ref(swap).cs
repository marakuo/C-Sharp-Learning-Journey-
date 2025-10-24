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
           
            Console.WriteLine("enter the old name");
             string nameold = Console.ReadLine();
            Console.WriteLine("enter the new one");
             string namenew = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"the old name is {nameold}");
            Console.WriteLine();
            SwapString(ref nameold, ref namenew);
            Console.WriteLine($"the new name is {nameold}");





        }

        static void SwapString(ref string str1, ref string str2)
        {
           string temp = str1;
            str1= str2;
            str2 = temp;

            Console.WriteLine($"Inside the meathod old name is {str2} and new one is {str1}");
            Console.WriteLine();
            

        }






    }

}

