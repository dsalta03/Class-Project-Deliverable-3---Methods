/*
    Author: Saltanat Degenbaeva
    Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user. 
*/
using System;

namespace Class_Project_Deliverable_3___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter your name
            Console.WriteLine("Please enter your name: ");
           // Change the color
                Console.ForegroundColor = ConsoleColor.Green;
                string name = Console.ReadLine();
                Console.WriteLine("Hello " + name + "!");
            //Exit the program
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            

        }
    }
}
