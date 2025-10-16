using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Text; // for string builder 



namespace malak
{
    //class for a calculator
    class calculator
    {
        // addition 
        public  int sum(int n1, int n2)
        {
            return n1 + n2;
        }
        //sub 
        public int sub(int n1,int  n2)
        {
            return n1 - n2;
        }

        //multi
        public int multiply(int n1, int n2)
        {
            return n1 *n2;
        }

        // div 
        public int divide(int n1, int n2)
        {
            if (n2 == 0) return 0;
            else
            {
                return n1 / n2;
            }

        }
        








    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //accessing the class
            calculator c = new calculator();
            Console.WriteLine("---- Welcome to my Calculator ----");
            Console.Write("Enter the first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the operation: ");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine();
            //switch case 
            switch (op){
                case '+':
                    Console.WriteLine($"{n1} + {n2} = {c.sum(n1, n2)}"); break;
                case '-':
                    Console.WriteLine($"{n1} - {n2} = {c.sub(n1, n2)}"); break;
                case '*':
                    Console.WriteLine($"{n1}+{n2} = {c.multiply(n1, n2)}"); break;
                case '/':
                    Console.WriteLine($"{n1} / {n2} = {c.divide(n1, n2)}"); break;
                default:
                    Console.WriteLine("Invalid input"); break;




            }



        }
     
       
       
       
    }
}

