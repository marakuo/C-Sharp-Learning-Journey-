// witout static 
/*
object is a copy of the class 
each object has its own separate copy of carCounter.
Each object increases its own counter only, not a shared one.
*/
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Car car1 = new Car("LUM");
             Car car2 = new Car("tuyota");
             Console.WriteLine(car1.carCounter);
             Console.WriteLine(car2.carCounter);
        }
    }
    class Car
    {
        public string name;
        public int carCounter;
        public Car (string name)
        {
            this.name = name;

            carCounter++;
        }
    }

   
}
// using static 
/*
carCounter is static, so it belongs to the class itself, NOT to each object.
All objects share the same counter.
*/
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            
             Car car1 = new Car("LUM");
             Car car2 = new Car("tuyota");
             Car car3 = new Car("UUU");
             Console.WriteLine(Car.carCounter); // ClassName.Method();
             
             
        }
    }
    class Car
    {
        public string name;
        public static int carCounter;
        public  Car (string name)
        {
            this.name = name;

            carCounter++;
        }

        
    }

   
}
