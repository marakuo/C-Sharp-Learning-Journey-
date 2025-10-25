// change old password 
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
// reset to zero 
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

            int hours = 4;
            int minutes = 40;
            Console.WriteLine($"Time Taken {hours} : {minutes}");
            ResetToZero(ref hours);
            ResetToZero(ref minutes);
            Console.WriteLine($"Time reset {hours} : {minutes}");

        }
        static void ResetToZero(ref int reset)
        {
            reset = 0;
            
        }
    
    }


    }

// capitalize string 
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

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            Capitalize(ref name);
            Console.WriteLine(name);


        }
        static void Capitalize(ref string name)
        {
            name = name.ToUpper();
            

        }
    
    }
    }








