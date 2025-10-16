// calculate the sum of products prices 
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text;



namespace malak
{
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //passing an array into a method
            double[] prices = { 22.6, 665.09, 120.43, 90, 340.8 };
            Console.WriteLine(totalsum(prices));


        }
        //methods 
       static double totalsum(double[] prices)
        {
            double sum = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                sum+= prices[i];

            }
            return sum;

        }
       
       
    }

}
////////////////////////////////////////
// method to display the array taken from user 

using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text; // for string builder 



namespace malak
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of elements: ");
            int n =int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"element {i+1}: ");
                arr[i]=int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("----- THE ARRAY -----");


            PrintArray(arr);



        }
        //methods 
       static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
                arr[i] *= 2;
            }
        }
       
       
    }

}



///////

