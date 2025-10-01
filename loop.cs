// multiplication table 
using System;
using System.Dynamic;

namespace malak
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for(int i =0; i <8; i++)
            {
                for(int j =1; j <8; j++) // apply it to any number
                {
                    Console.WriteLine($"{i}X{j}= {i *j}");
                }
                Console.WriteLine();
            }


        }
    }
}
///////////////////////////////

// stars battern 
using System;
using System.Dynamic;

namespace malak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
                int rows = int.Parse(Console.ReadLine());
           
            for(int i =1; i <=rows; i++)
            {
                for(int j =1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }


        }
    }
}
/*
Enter the number of rows: 5
*
**
***
****
*****
*/
/////////////////////
// the factorial of a number 

using System;
using System.Dynamic;

namespace malak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 1,  i;
            if (n == 0)
            {
                Console.WriteLine($"the factorial of {n} = one");
            }
            else
            {
                for ( i = 1; i <= n; i++) fact *= i;

                Console.WriteLine(fact);

            }

        }
    }
}
//////////////////////
//summation of first n numbers 
using System;
using System.Dynamic;

namespace malak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"the summation of first {n} numbers is {sum}");

        }
    }
}
//////////////////////////
// counting the number of digits 
using System;
using System.Dynamic;

namespace malak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int count = 0;
            if (n == 0) count = 1;
            while (n != 0)
            {
                n /= 10; // gets digit by digit 
                count++;
            }
            Console.Write($"the number of digits of {number} is {count}");


        }
    }
}
/////////////////////
/////////////////////////////////////////////////////////////////////// digit-based problems ///////////////////////////////////////////////////////////////////////

/*  division by 10 removes a digit
1234 / 10 = 123
123 / 10 = 12
12 / 10 = 1
1 / 10 = 0
*/


/*  modulus  10 removes gives the last digit
1234 % 10 = 4
123 % 10 = 3
12 % 10 = 2
1 % 10 = 1

*/
/////////////////////////
// the sum of digits of a number 

using System;
using System.Dynamic;

namespace malak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int sum =0, number =n;
            
            while(n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine($"the sum of digits of {number} is {sum}"); 
           

        }
    }
}

