using System;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Transactions;
using System.Xml;


namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            child ch = new child(); // parent constructor will be called first then the child 






        }
        
    }

    class parent
    {
        public parent()
        {
            Console.WriteLine("this is the parent constructor");
        }
    }

    class child : parent
    {
        public child()
        {
            Console.WriteLine("this is the child constructor");
        }
    }

 
    

   
   

    
    
}
