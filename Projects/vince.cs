//Module 1
using System;

namespace FinalProject
{

    public class Program
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("*Module 1*");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to this Program!");

            //Data types
            int x = 2;
            int y = 4;
            string name = "Vince";
            double z = 20.30;
            char label = 'B';
            bool isTrue = false;

            Console.WriteLine(x + "\n" + y + "\n" + name + "\n" + z + "\n" + label + "\n" + isTrue);

            //Module 2\
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            Console.WriteLine("*Module 2*");
            Console.WriteLine("~~~~~~~~~~~~~~~~~");

            //Arithmetic Operators
            int a = 12;
            int b = 20;

            int sum = a + b;
            int multiply = a * b;
            int difference = a - b;
            int quotient = a / b;
            int remainder = a % b;
            //Assignment Operators
            ++a;
            --b;

            Console.WriteLine(a);

            //User Input 
            string message;

            message = Console.ReadLine();
            Console.Write("You are gladly welcome....");
            Console.WriteLine(message);

            //More on Strings
            Console.WriteLine("Welcome\nto the program");
            Console.WriteLine("Welcome\tto the program");
            Console.WriteLine(@"Welcome!
            to the program");

            //Concatenation and Interpolation

            string firstName = "Vince";
            string lastName = "Dela Cerna";

            string fullNameConcatenated = firstName + " " + lastName;
            Console.WriteLine("Concatenation: " + fullNameConcatenated);


            string fullNameInterpolated = $"{firstName} {lastName}";
            Console.WriteLine($"Interpolation: {fullNameInterpolated}");

            //Module 3
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("*Module 3*");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

            // Comparison, Logical operators, if, else-if statement
            int price = 30;
            int price2 = 50;


            if (price == price2)
            {
                Console.WriteLine($"{price} is equal to {price2}");
            }
            else if (price < price2 && price % 2 == 0)
            {
                Console.WriteLine($"{price} is less than {price2} and even");
            }
            else if (price < price2 || price % 2 == 0)
            {
                Console.WriteLine($"{price} is either less than {price2} or even");
            }
            else
            {
                Console.WriteLine($"{price} is greater than {price2} and odd");
            }

            //Switch statement
            Console.WriteLine("Pick a number: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("coke");
                    break;

                case 2:
                    Console.WriteLine("royal");
                    break;

                case 3:
                    Console.WriteLine("sprite");
                    break;

                case 4:
                    Console.WriteLine("yakult");
                    break;
                default:
                    Console.WriteLine("Out of Order!");
                    break;
            }

            //Module 4
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("*Module 4*");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

            //For loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For Loop");
            }

            //While loop
            int loop = 1;


            while (loop <= 5)
            {
                Console.WriteLine($"While loop {loop}");
                loop++;
            }

            Console.WriteLine("Loop finished!");

            //Module 5
            Console.WriteLine("~~~~~~~~~~~~~");
            Console.WriteLine("*Module 5*");
            Console.WriteLine("~~~~~~~~~~~~~");

            //Methods
            int num = AddNumbers(5, 3);
            Console.WriteLine($"Sum: {sum}");

            GreetUser("Program");

            bool isEven = IsEven(8);
            Console.WriteLine($"Is the number even? {isEven}");
            }

            static int AddNumbers(int a, int b)
            {
            return a + b;
            }

            static void GreetUser(string name)
            {
            Console.WriteLine($"Welcome, {name}!");
            }

            static bool IsEven(int number)
            {
            return number % 2 == 0;
            
            }


        
    }
}
