using System;
using System.Reflection;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Test test = new Test("malk", 19); // parameterized constructor 
            
             

        }
    }

    class Test
    {
        public string name; 
        public int age;
       
        public Test(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        
    }
    
}
