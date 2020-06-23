using System;
using System.ComponentModel;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            //assign a random number inside of favNumber variable
            var favNumber = r.Next(1, 1000);


            Console.WriteLine($"Try to correctly guess the random number");

            //convert user input(string) into an int
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!!!!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High!!!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

        }

    
    
    
    
    
    }
    
    
   

}
