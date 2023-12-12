using System;
using System.Diagnostics.Metrics;
using System.IO;

namespace FinalHanginon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1.
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Module 1.\n*Welcome to my Final Project in OOP *");
            Console.WriteLine("\n-------------------------------------");
            int x = 8, y = 11;
            double z = 5.1;
            char d = 'd';
            bool isFalse = false;
            Console.WriteLine(x + y);
            Console.WriteLine(d + "\n" + z + "\n" + isFalse + "\n" + x + "\n" + y + "\n");
            //Module 2
            Console.WriteLine("Module 2.");
            //ArithmeticOperators
            int a = 10;
            int b = 3;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            int num = 8;
            num++;
            num--;
            Console.WriteLine(x);
            //AssignmentOperator
            int numm = 8;
            numm += 3;
            numm -= 3;
            numm /= 3;
            numm *= 3;
            numm %= 3;
            Console.WriteLine(num + "\nEnter your FullName: ");
            string message = @",Welcome to OnePiece World !
            HOW ARE YOU?";
            string user = Console.ReadLine();
            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine($"Hi {user} " + message + "\t ");


            //Module 3
            Console.WriteLine($"Module 3.\nEnter your age  {user}");
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
            Console.WriteLine("Choose your Best Character: \n 1.Luffy \n 2.Sanji \n 3. Zoro \n 4. None");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monkey D. Luffy,\nLuffy, also known as Straw Hat Luffy and commonly as Straw Hat is the founder and captain of the increasingly infamous and powerful Straw Hat Pirates, as well as the most powerful of its top fighters.He desires to find the legendary treasure left behind by the late Gol D. Roger and thereby become the Pirate King,which would help facilitate an unknown dream of his that he has told only to Shanks, his brothers, and crew.");
                    break;
                case 2:
                    Console.WriteLine("Vinsmoke Sanji,\nSanji, born as Vinsmoke Sanji and also known as \"Black Leg\" Sanji, is a fictional character in the One Piece franchise created by Eiichiro Oda. A native to the North Blue, Sanji grew up as part of the Vinsmoke family under his father Vinsmoke Judge, king of the Germa Kingdom, and mother Vinsmoke Sora.");
                    break;
                case 3:
                    Console.WriteLine("Roronoa Zoro,\nZoro,also known as Pirate Hunter Zoro is a main combatant of the Straw Hat Pirates, one of their two swordsmen, one of the Senior Officers of the Straw Hat Grand Fleet,and is publicly recognized as the right-hand man of his crew's captain Monkey D. Luffy.[");
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
            //Module 5
            Console.WriteLine("Module 5");
            static void Welcome()
            {
                Console.WriteLine("Did you enjoy your trip in one piece world?");
                Console.WriteLine("How was your trip?");
            }
            Welcome();
            static void WelcomeNakama(string name)
            {
                Console.WriteLine("See You Around " + name);
            }
            WelcomeNakama("Myca !");
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