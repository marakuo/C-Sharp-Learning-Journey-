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
// Overloading
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
// using parametrized constructor for static fields
using System;
using System.Reflection;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car("BMW");
            Car car2 = new Car("Audi");
            Car car3 = new Car("BMW");
            // count the number of cars created for the whole class
            Console.WriteLine("The number of cars "+Car.CarCounter); // 3
             

        }
    }

    class Car
    {
        public string brand;
        public static int CarCounter;

        public Car(string brand)
        {
            this.brand = brand;
            CarCounter++;
           
           
        }
        

    }
}
// ex 2 
using System;
using System.Reflection;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMeeting[] students =
            {
                new ClassMeeting("Malk", "njhfgmail.com", 67643),
                new ClassMeeting("Heba", "heb@gmail.com", 67364)
            };
            Console.WriteLine("The number of students in the meeting is " +ClassMeeting.studentCounter);



        }
    }

    class ClassMeeting{
        public string studentName;
        public string studentEmail;
        public int studentId;
        public static int studentCounter;

        public ClassMeeting(string studentName, string studentEmail, int studentId)
        {
            this.studentName = studentName;
            this.studentEmail = studentEmail;
            this.studentId = studentId;
            studentCounter++;
        }
        


    }
}
