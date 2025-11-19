using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] arr =
            {
                new Employee(){name ="malk",id = 232, salary =3990 },
                new Employee(){name ="mohamed",id = 300, salary =3009 },
                new Employee(){name ="john",id = 543, salary =4000 },
                new Employee(){name ="luke",id = 786, salary =5000 },
                
                

            };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"name of employe {i+1} is{arr[i].name}");
                Console.WriteLine($"id of employe {i+1} is{arr[i].id}");
                Console.WriteLine($"salary of employe {i+1} is{arr[i].salary}");
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
        

        
    }
   
        
}

///////////////////////
// searching inside
using System;

namespace csharpcode
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] arr =
            {
                new Employee(){name ="malk",id = 232, salary =3990 },
                new Employee(){name ="mohamed",id = 300, salary =3009 },
                new Employee(){name ="john",id = 543, salary =4000 },
                new Employee(){name ="luke",id = 786, salary =5000 },
                
                

            };
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].name=="malk") Console.WriteLine($"hello malk ur id is {arr[i].id}");
                if(arr[i].salary==5000) Console.WriteLine($"the employee name is {arr[i].name}");
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
        

        

        
    }
   
        
}
    
