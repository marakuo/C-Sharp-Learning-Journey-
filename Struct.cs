using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text; // for string builder 



namespace malak
{

    internal class Program
    {
        static void Main(string[] args)
        {

           employee emp = new employee(1222, "malk", "SWE"); // constructor 
            employee emp1 = new employee(1323,"heba", "pharmacist"); // constructor 

            // to print the values 
            Console.WriteLine(emp);
            Console.WriteLine(emp1);


        }
       
        struct employee
        {
            int id;
            string name;
            string title;
            public employee(int _id, string _name, string _title)
            {
                id = _id;   
                name = _name;
                title = _title;
                
            }
//            important
//           By default, the inherited ToString() method just returns the object's type name (like "malak.Program+employee").

//The override keyword says: "I don't want the default, inherited version. I want to replace it with my own custom version."
            public override string ToString()
            {
                return $"id = {id}, name = {name}, title = {title}";
            }

        }
       

    }
}
///////////////////////////////
using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text; // for string builder 



namespace malak
{

    internal class Program
    {
        static void Main(string[] args)
        {

           employee emp = new employee(221, "", "SWE"); // constructor 
            employee emp1 = new employee(1323,"heba", "pharmacist"); // constructor 

            // to print the values 
            emp.SetName("");
           

         
            Console.WriteLine(emp1);
            Console.WriteLine(emp);


        }
       
        struct employee
        {
            int id;
            string name;
            string title;
            public employee(int _id, string _name, string _title)
            {
                id = _id;   
                name = _name;
                title = _title;
                
            }
            public void SetName(string _name) 
            {
                if (name == string.Empty)
                    {
                        name = "new employee";
                    }
                else
                    {
                        name = _name;

                    }

            }
            public void SetId(int _id)
            {
                if (id == 0)
                {
                    id = 1;
                }
                else
                {
                    id = _id;
                }
            }
            
            public override string ToString()
            {
                return $"id = {id}, name = {name}, title = {title}";
            }

        }
       

    }
}





////////////////////




