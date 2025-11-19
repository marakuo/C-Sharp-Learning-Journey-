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

////////////////////


using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter your name:\t");
           emp.Name = Console.ReadLine();
            Console.Write("Enter your ID:\t");
            emp.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter your salary:\t");
            emp.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=== Employee's data ===");
            

            Console.WriteLine(emp.name);
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.salary);

        }
        // end of main
        
        
    }
    // end of class 
    class Employee
    {
        public string name;
        public int id;
        public double salary;
        // creating properties 
        public string Name
        {
            set
            {
                if (value.Length < 3 || value == string.Empty)
                {
                   name = "New Employee";
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;

            }
            
        }

        public double Salary
        {
            set
            {
                if (value < 20000 && value > 5000)
                {
                    salary = value;
                }
                else
                {
                    salary = 5000;
                    
                }
            }
            get
            {
                return salary;
            }
        }

        public int ID
        {
            set
            {
                if (value > 0 && value < 20)
                {
                    id = value;
                }
                else
                {
                    id = 1;
                }
            }
            get
            {
                return id;
            }
        }

       

        
    }
   
        
}
    
    
    
    /////////////////////////////
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee [] emp =
            {
                new Employee("Malk", 5, 2000),
                new Employee("heba", 6, 3000),
                new Employee("Michael", 7, 4000),
                
            };
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }

        }
        // end of main
        
        
    }
    // end of class 
    class Employee
    {
        public string name;
        public int id;
        public double salary;
        // creating properties 
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public override string ToString()
        {
           return $"name : {name}, id: {id}, salary: {salary}";
        }
    }
   
        
}
    
    
    
    
/////////////using foreach
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee [] emp =
            {
                new Employee("Malk", 5, 2000),
                new Employee("heba", 6, 3000),
                new Employee("Michael", 7, 4000),
                
            };
            foreach (Employee Emp in emp)
            {
                Console.WriteLine(Emp);
            }

        }
        // end of main
        
        
    }
    // end of class 
    class Employee
    {
        public string name;
        public int id;
        public double salary;
        // creating properties 
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public override string ToString()
        {
           return $"name : {name}, id: {id}, salary: {salary}";
        }
    }
   
        
}
    
    
    
    

    

    

    

    


    

    

