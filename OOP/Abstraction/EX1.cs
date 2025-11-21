using System;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Transactions;


namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius:\t");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            Console.WriteLine("The area of the circle is: "+ circle.Area());
            Console.WriteLine();
            Console.Write("Enter the side length:\t");
            double side = double.Parse(Console.ReadLine());
            Square sqaure = new Square(side);
            Console.WriteLine("The area of the Square is: "+ sqaure.Area());



        }
    }

    abstract class Shape   // base class (cannot create an object from abstract class
    {
        // common method between the subclass but every subclass implement it differently 
         public abstract double Area(); // abstract method with no implementation 
         
    }
    
    // subclasses 
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Square : Shape
    {
        public double SideLength { get; set; }

        public Square(double SideLength)
        {
            this.SideLength = SideLength;
        }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }


   

    
    
}
