using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text; // for string builder 



namespace malak
{

    internal class Program
    {
        static void Main(string[] args)
        {

            MonthDays monthdays = new MonthDays();
            Console.WriteLine(monthdays[1]);

        }
        public class MonthDays
        {
            private int[] Days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            
            // creating indexers 
            public int this[int month]
            {
                get { return Days[month - 1]; }
                set { Days[month - 1] = value; }
            }




        }


    }
}





