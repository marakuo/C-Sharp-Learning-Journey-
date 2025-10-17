// Factorial 
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
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            Console.WriteLine($"The Factorial of {n} is {Factorial(n)}");
          
        }
        //Recursive methods 
       static int Factorial(int n)
        {
            if(n== 0) return 1; // base case
            return n * Factorial(n - 1);
        }
       
    }

}
////////////////////////////////////////////
//Displaying folders & files inside 

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
            string path = string.Empty;
             path = @"E:\Movies";
            Console.WriteLine(path);
            DisplayMovies(path,0);


        }
        //Recursive method
        static void DisplayMovies(string path, int indent)
        {
            foreach(var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ',indent)} {Path.GetFileName(folder)}");
                DisplayMovies(folder, indent +1);
            }
        }
       
       
    }

}
/*
E:\Movies
 Detective Conan
  Season 1
 Yona of the dawn
  Season 1
*/ 


