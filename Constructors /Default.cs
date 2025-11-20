// Implicit Default Constructor
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Test test = new Test(); // default constructor with no initialization 
            Console.WriteLine(test.age); // 0
            Console.WriteLine(test.name); // null
             

        }
    }

    class Test
    {
        public string name; 
        public int age;
        // at run time name = null , and age =0 (default values)

        
    }
    
}

// Explicit Default Constructor
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Test test = new Test(); // default constructor with  initialization 
            Console.WriteLine(test.age); // 19
            Console.WriteLine(test.name); // Malk
             

        }
    }

    class Test
    {
        public string name; 
        public int age;
        // name = Malk , and age =19 (default value)
        public Test()
        {
            name = "Malk";
            age = 19;
        }

        
    }
    
}
