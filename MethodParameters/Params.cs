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


    
// email subjet from to 
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
            CreateEmail("Meeting", "boss@company.com", "alice@company.com", "bob@company.com");
            CreateEmail("Newsletter", "news@company.com", "subscriber1@email.com");


        }

        static void CreateEmail(string subject, string from, params string[] recipients)
        {
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"From: {from}");
            Console.WriteLine("To: " + string.Join(", ", recipients));
        }




    }
    }


    






