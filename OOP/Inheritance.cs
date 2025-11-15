using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
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
            // Assuming your class is named "Dog"
            Dog myDog = new Dog();


            myDog.AnimalName = "Lossy";
            myDog.AnimalDateOfBirth = new DateOnly(2020, 02, 23);
            myDog.DogBreed = "Border Collie";
            myDog.EaslyTrained = 10;  // Using a 1-10 scale
            myDog.DogIntelligence = 10; // Using a 1-10 scale
            
            static void display(Dog myDog)
            {
                Console.WriteLine(myDog.AnimalName);
                Console.WriteLine(myDog.AnimalDateOfBirth);
                Console.WriteLine(myDog.DogBreed);
                Console.WriteLine(myDog.EaslyTrained);
                Console.WriteLine(myDog.DogIntelligence);

            }
            display( myDog);

            myDog.AnimalFeed();

            Bird myBird = new Bird();
            myBird.AnimalName = "JJ";
            myBird.AnimalDateOfBirth = new DateOnly(2023, 03, 21);
            myBird.BirdColor = " yellow";
            myBird.Attitude = 2;
            static void displaytwo(Bird myBird)
            {
                Console.WriteLine(myBird.AnimalName);
                Console.WriteLine(myBird.AnimalDateOfBirth);
                Console.WriteLine(myBird.BirdColor);
                Console.WriteLine(myBird.Attitude);
                
                

            }


            displaytwo(myBird);



        }






    }

 
}

// creatng the parent  class 

class Animal
{
    // properties 
    public string AnimalName { get; set; }
    public DateOnly AnimalDateOfBirth { get; set; }
     // methods 
     public void AnimalFeed() {
        Console.WriteLine("Eat Meat");
    
    }
}
// child classes 
class Dog : Animal
{
    public string DogBreed { get; set; }
    public int EaslyTrained { get; set; }
    public int DogIntelligence { get; set; }
}
class Bird : Animal
{
    public string BirdColor { get; set; }
    public double Attitude { get; set; }    
}





