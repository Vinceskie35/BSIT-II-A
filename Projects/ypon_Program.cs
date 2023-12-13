using System;
namespace FinalYPON
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1.
            Console.WriteLine("Module 1.\nThis is my Final Project in OOP");


            Console.WriteLine(" --------------------------------------------------------------------------------YOU HAVE A FREE TRAVEL PACKAGE FOR US AND YOU CAN USE IT ANYWHERE----------------------------------------------------------------------------");




            Console.WriteLine(" Module 1. Program Structure, Basic Concepts, Variables, Data Types,Doing math");

            int x = 10, y = 12;
            double z = 2.1;
            char d = 'd';
            bool isFalse = false;
            Console.WriteLine(x + y);
            Console.WriteLine(d + "\n" + z + "\n" + isFalse + "\n" + x + "\n" + y + "\n");
            //Module 2
            Console.WriteLine("Module 2.");

            Console.WriteLine("Module 2. Arithmetic Operators, Assignment Operators, User Input, More on Strings, Concatenation and Interpolation");
            //Arithmetic Operators
            int a = 10;
            int b = 3;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            int num = 5;
            num++;
            num--;
            Console.WriteLine(x);
            //Assignment Operator
            int numm = 5;
            numm += 3;
            numm -= 3;
            numm /= 3;
            numm *= 3;
            numm %= 3;
            Console.WriteLine(num + "\nEnter your Destinations: ");
            string message = @",Welcome to INDONESIA!
            
            answer my question to get the free travel package";
            string user = Console.ReadLine();
            Console.WriteLine($"Here are the travel package we offer in {user} " + message + "\t :0");

            //Module 3
            Console.WriteLine(" Module 3. If Statement, else  if Statement , else Statement , Logical Operators, Switch Statement, Ternary Operator");


            Console.WriteLine($"Module 3.\nEnter how many people to travel with you in  {user}");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age == 0)
            {
                Console.WriteLine("SOLO PACKAGE");
            }
            else if (age > 1 && age <= 17)
            {
                Console.WriteLine("COUPLE'S PACKAGE");
            }
            else if (age >= 18 && age <= 40)
            {
                Console.WriteLine("FAMILY PACKAGE");
            }
            else
            {
                Console.WriteLine("BARKADA PACKAGE");
            }
            Console.WriteLine("Choose your FREE'S: \n 1.ROUNDTRIP AIRLINE TICKETS \n 2.MEALS AND BEVERAGES \n 3. HOTEL\n 4. POOLS AND AMMENETIES");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("GREAT, YOU  NOW UNLOCK YOUR FREE TRAVEL IN Bali,Indonesia");
                    break;
                case 2:
                    Console.WriteLine("GREAT, YOU NOW UNLOCK YOUR FREE TRAVEL IN Las Vegas, Boulevard");
                    break;
                case 3:
                    Console.WriteLine("GREAT, YOU NOW UNLOCK YOUR FREE TRAVEL IN Miami, Wynwood Walls");
                    break;
                default:
                    Console.WriteLine("GREAT, YOU NOW UNLOCK YOUR FREE TRAVEL IN Florida,Everglades National Park");
                    break;

            }
            int ex = 100;
            int ey;
            ey = (ex > 10) ? 20 : 30;
            Console.WriteLine(ey);
            //Module 4.
            //For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int r = 0;
            while (r < 5)
            {
                Console.WriteLine(r);
                r++;
            }
            //Break and Continue
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            //Module 5
            Console.WriteLine("Module 5");
            static void Welcome()
            {
                Console.WriteLine("Welcome to BALI, INDONESIA");
                Console.WriteLine("MY DREAM PLACE TO TRAVEL");
                Console.WriteLine("Let's Explore here in BALI");
            }
            Welcome();
            static void WelcomeHome(string name)
            {
                Console.WriteLine("Welcome " + name);
            }
            WelcomeHome("Stephanie");
            static int bday(int year, int age)
            {
                int yourAge = year - age;
                return yourAge;
            }
            int mybday = bday(2023, 19);
            Console.WriteLine($"I WAS PLANNING TO TRAVEL HERE  LAST {mybday}");
        }
    }
}
