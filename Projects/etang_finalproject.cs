using System;
namespace FinalEtang
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1.
            Console.WriteLine("Module 1.\nMaligayang pagdating sa aking Proyekto sa OOP");
            int x = 12, y = 16;
            double z = 3.1;
            char d = 'd';
            bool isTrue = true;
            Console.WriteLine(x + y);
            Console.WriteLine(d + "\n" + z + "\n" + isTrue + "\n" + x + "\n" + y + "\n");
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
            Console.WriteLine(num + "\nEnter your unique name: ");
            string message = @",Welcome to OOP!
            Hello Friend";
            string user = Console.ReadLine();
            Console.WriteLine($"Hi {user} " + message + "\t :0");

            //Module 3
            Console.WriteLine($"Module 3.\nEnter your unique age {user}");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age == 0)
            {
                Console.WriteLine("Young");
            }
            else if (age > 1 && age <= 20)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 18 && age <= 40)
            {
                Console.WriteLine("Child");
            }
            else
            {
                Console.WriteLine("Old");
            }
            Console.WriteLine("Choose your Town: \n 1.Cebu \n 2. Manila \n 3. Bicol  \n 4. Masbate");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Cebu");
                    break;
                case 2:
                    Console.WriteLine("Manila");
                    break;
                case 3:
                    Console.WriteLine("Bicol");
                    break;
                default:
                    Console.WriteLine("Masbate");
                    break;

            }
            int ex = 105;
            int ey;
            ey = (ex > 12) ? 25 : 35;
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
                Console.WriteLine("Maligayang pagbabalik");
                Console.WriteLine("Is everything okay??");
                Console.WriteLine("Im happy for you");
            }
            Welcome();
            static void WelcomeHome(string name)
            {
                Console.WriteLine("Maligayang Pagbabalik " + name);
            }
            WelcomeHome("Etang");
            static int christmas(int year, int month)
            {
                int Yourage = year - month;
                return Yourage;
            }
            int mychristmas = christmas(2023, 0);
            Console.WriteLine($"Merry Christmas {mychristmas}");
        }
    }
}



