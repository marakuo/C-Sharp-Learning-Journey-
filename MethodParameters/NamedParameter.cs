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
            NamedParamter(s3: "mohamed ", s2: "abdelhamed ", s1: "malk ");
        
        }
        public static void NamedParamter(string s1,string s2, string s3)
        {
            string result = s1 + s2 + s3;
            Console.WriteLine(result);
        } 

    }


    }



