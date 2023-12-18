using System;

namespace FareCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Fare Calculator!");

            bool exit = false;

            do
            {
                
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                
                int age;
                while (true)
                {
                    Console.Write("Enter your age: ");
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid age.");
                    }
                }

                
                double distance;
                while (true)
                {
                    Console.Write("Enter the distance covered in kilometers: ");
                    if (double.TryParse(Console.ReadLine(), out distance))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid distance.");
                    }
                }

                double fareRate = 2.5;

                
                double fare = distance * fareRate;

                
                if (age < 18 || age > 60)
                {
                    fare *= 0.8; 
                }

                Console.WriteLine($"Hello, {name}!");
                Console.WriteLine($"Based on the distance of {distance} km, your fare is: ${fare}");

                
                Console.Write("Do you want to calculate fare again? (yes/no): ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput != "yes")
                {
                    exit = true;
                }

            } while (!exit);

            Console.WriteLine("Thank you for using the Fare Calculator!");
        }
    }
}
