
using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text; // for string builder 



namespace malak
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an instance from the created class (1st person)
            Person PersonOne = new Person();
            PersonOne.FirstName = "Malk";
            PersonOne.LastName = "Abdelhamed";
            PersonOne.Country = " Egypt";
            PersonOne.BirthDate = new DateOnly(2006, 01, 14);
            
            
            // creating an instance from the created class (2nd person)
            Person PersonTwo = new Person();
            PersonTwo.FirstName = "Youna";
            PersonTwo.LastName = "Huk";
            PersonTwo.Country = " Japan";
            PersonTwo.BirthDate = new DateOnly(1999, 12, 15);
            
            static void DiaplayData(Person person)
            {
                Console.WriteLine("=== Data ===");
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
                Console.WriteLine($"Country: {person.Country}");
                Console.WriteLine($"Date of birth: {person.BirthDate}");
            }
            DiaplayData(PersonOne);
            DiaplayData(PersonTwo);





        }






    }

// creatng a class 
 class Person
    {
        // variables (private by default == accessed through properties)
        string firstName;
        string lastName;
        DateOnly birthDate;
        string country;
        // properties 
        public string FirstName 
        {
            get { return firstName; }
            set { firstName = value; }

        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateOnly BirthDate
        {
            get { return birthDate; }   
            set {  birthDate = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }



    }
    }






