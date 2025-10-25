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
            Console.Write("Enter ur name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter ur age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine();
           details(name, age);


        }
       
        static void details(string name, int age, double gpa =4.0, string dep = "Review Team")
        {
            Console.WriteLine($"Employee name {name}");
            Console.WriteLine($"Employee age {age}");
            Console.WriteLine($"Employee gpa {gpa}");
            Console.WriteLine($"Employee department {dep}");

        }


    }


    }



