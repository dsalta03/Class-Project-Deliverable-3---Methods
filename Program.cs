/*
    Author: Clinton Daniel
    Date: 1/5/2019
    Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user. The program has two
              methods. One value return method and one void method.
              One method is designed to calculate the users maximum heart rate
              after entering their age. The other method is designed to 
              calculate the users recommended heart rate range during exercise
              based on the calculated maximum heart rate. 
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
