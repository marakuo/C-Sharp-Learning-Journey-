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
            TryDynamic("malak");
            TryDynamic(78);
            TryDynamic(90.7);
            TryDynamic(new int[] {1,3,4});

        }



       static void TryDynamic(dynamic dyn)
        {
            Console.WriteLine($"The Value is: {dyn}");
            Console.WriteLine($"The Type is: {dyn.GetType()}");
            Console.WriteLine();
            try
            {
                Console.WriteLine($"Length: {dyn.Length}");
               
            }
            catch( Exception ex ) 
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        }
    }


    



