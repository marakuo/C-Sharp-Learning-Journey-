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
            int[] arr = sumsub(20, 30);
            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            

        }
       
        static int[] sumsub(int x , int y)
        {
            int[] result = new int[2];
            result[0] = x+y;
            result[1] = Math.Abs(x - y);
            return result;  

        }
       


    }


    }



