using System;
namespace FinalSanchez
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1.
            Console.WriteLine("Module 1.\nWelcome to my Final Project in OOP");
            int x = 10, y = 12;
            double z = 2.1;
            char d = 'd';
            bool isFalse = false;
            Console.WriteLine(x + y);
            Console.WriteLine(d + "\n" + z + "\n" + isFalse + "\n" + x + "\n" + y + "\n");
            //Module 2
            Console.WriteLine("Module 2.");
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
            Console.WriteLine(num + "\nEnter your name: ");
            string message = @",Welcome to OOP!
            Hey There";
            string user = Console.ReadLine();
            Console.WriteLine($"Hi {user} " + message + "\t :0");

            //Module 3
            Console.WriteLine($"Module 3.\nEnter your age {user}");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age == 0)
            {
                Console.WriteLine("Baby");
            }
            else if (age > 1 && age <= 17)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 18 && age <= 40)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Old");
            }
            Console.WriteLine("Choose your Course: \n 1.BSIT \n 2.BSHM \n 3. BSED \n 4. None");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("BSIT");
                    break;
                case 2:
                    Console.WriteLine("BSHM");
                    break;
                case 3:
                    Console.WriteLine("BSED");
                    break;
                default:
                    Console.WriteLine("None");
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
            //Module 4
            Console.WriteLine("Module 4");
            static void Welcome()
            {
                Console.WriteLine("Welcome Home");
                Console.WriteLine("How are you?");
                Console.WriteLine("I miss you, balik kana sakin");
            }
            Welcome();
            static void WelcomeHome(string name)
            {
                Console.WriteLine("Welcome " + name);
            }
            WelcomeHome("Christian");
            static int bday(int year, int age)
            {
                int yourAge = year - age;
                return yourAge;
            }
            int mybday = bday(2023, 19);
            Console.WriteLine($"My Birthyear is {mybday}");
        }
    }
}