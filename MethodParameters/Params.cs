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
            ValueType("malak", 123, 34.5, new int[] { 2, 4, 6 }, true, DateTime.Now );


        }

        static void ValueType(params object[] values)
        {
            
            foreach(var value in values)
            {
                Console.WriteLine($"the value is {value}, and the type is {value.GetType()}");
            }
            
        }

       


        }
    }


    



