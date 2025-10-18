// simple book data setter and getter 
using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Text; // for string builder 



namespace malak
{

    internal class Program
    {
        static void Main(string[] args)
        {
           Book book = new Book();
            book.SetTitle();
            book.SetAuthor();
            book.SetPrice();
            book.PrintInfo();
           



        }
       



    }
    //class 
    public class Book
    {
        string title;
        string author;
        double price;

        // setter method for the title 
        public void SetTitle()
        {
            Console.Write("Enter book title: ");
            string ntitle = Console.ReadLine();
            title = ntitle;

        }
        //getter method for title 
        public string GetTitle()
        {
            return title;
        }

        // setter method for the author 
        public void SetAuthor()
        {
            Console.Write("Enter Author name: ");
            string nauthor = Console.ReadLine();
            author = nauthor;

        }
        //getter method for author 
        public string GetAuthor()
        {
            return author;
        }

        // setter method for the pric 
        public void SetPrice()
        {
            Console.Write("Enter Book Price: ");
            double nprice = Convert.ToDouble(Console.ReadLine());
            price = nprice;

        }
        //getter method for price 
        public double GetPrice()
        {
            return price;
        }
        // calling method
        public void PrintInfo()
        {
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price} EGP");
        }




    }


}

