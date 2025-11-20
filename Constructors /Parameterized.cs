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
// multiple 
using System;
using System.Reflection;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Test test = new Test("malk", 19); // parameterized constructor
            Test test2 = new Test(60.5);
            Console.WriteLine(test);
            Console.WriteLine(test2);
            
             

        }
    }

    class Test
    {
        public string name; 
        public int age;
        public double weight;
       
        public Test(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Test(double weight)
        {
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"name : {name}, age: {age}, weight: {weight}";
        }
    }
    
}
