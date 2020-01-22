using System;

namespace Day_1___After_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            /* okay, lets do today's assignment, but with validation for everything, reprompting the user if anything besides a number is entered
             * goal: design a program calculates the dimensions of a rectangle(room)
             * input: length, width, height ... all doubles
             * proccess: math
             * output: area, perimiter, volume
            */

            string userInput = "y";

            while (userInput == "y")
            {
                //intro
                Console.WriteLine("\nLet's calculate some room dimensions!");
                Console.WriteLine("-----------------\n");

                //get length
                Console.WriteLine("Length: ");
                string temp = Console.ReadLine();
                double len;
                bool isDouble = double.TryParse(temp, out len);
                while (isDouble == false)
                {
                    Console.WriteLine("Invalid entry. Please enter a number.");
                    temp = Console.ReadLine();
                    isDouble = double.TryParse(temp, out len);
                }

                //get width
                Console.WriteLine("Width: ");
                temp = Console.ReadLine();
                double wid;
                isDouble = double.TryParse(temp, out wid);
                while (isDouble == false)
                {
                    Console.WriteLine("Invalid entry. Please enter a number.");
                    temp = Console.ReadLine();
                    isDouble = double.TryParse(temp, out wid);
                }

                //get height
                Console.WriteLine("Height: ");
                temp = Console.ReadLine();
                double height;
                isDouble = double.TryParse(temp, out height);
                while (isDouble == false)
                {
                    Console.WriteLine("Invalid entry. Please enter a number.");
                    temp = Console.ReadLine();
                    isDouble = double.TryParse(temp, out height);
                }

                //math
                double area = len * wid;
                double perimiter = 2 * (len + wid);
                double volume = len * wid * height;

                //output
                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimiter: {perimiter}");
                Console.WriteLine($"Volume: {volume}");

                //prompt for more
                Console.WriteLine("\nWould you like to continue? (y/n)");
                userInput = Console.ReadLine();

                while (userInput != "y" && userInput != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    userInput = Console.ReadLine();
                }
            }
            Console.WriteLine("Goodbye");
        }
    }
}
