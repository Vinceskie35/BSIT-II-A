using System;
namespace FinalUndalok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Module 1.
            Console.WriteLine(".......................................................................\nModule 1: Getting Started\n.......................................................................\n My Final Project in OOP");
            Console.WriteLine("1.) Program Structure\n2.) Basic Concepts(Outut)\n3.) Variables\n4.) Data Types\n5.)  Doing Math\n");

            Console.WriteLine("My name is Leia Rose Undalok \nFrom BSIT-2A");
            Console.WriteLine("Nice meeting you here!");
            string costumer = "You are the Costumer";
            costumer = "Costumer";
            Console.WriteLine(costumer);

            int x = 90, y = 110;
            double hopegrade = 1.1;
            char firstletter = 'L';
            bool isFalse = false;
            Console.WriteLine(x + y);
            Console.WriteLine(firstletter + "\n" + hopegrade + "\n" + isFalse + "\n" + x + "\n" + y + "\n");

            //Module 2
            Console.WriteLine("......................................................................\n Module 2 : Operator and String\n......................................................................\n My Final Project in OOP");
            Console.WriteLine("1.) Arithmetic operators\n2.) Assignment Operators \n3.) User Input\n4.) More on String\n5.) Concatenation and Interpolation");
            //Arithmetic Operators
            int a = 20;
            int b = 18;
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
            int numm = 8;
            numm += 2;
            numm -= 2;
            numm /= 2;
            numm *= 2;
            numm %= 2;


            //User Input, more on string ,and concatenation and interpolation


            string message = @",Welcome to our humble restuarant!
            Order";
            Console.WriteLine(num + "\nEnter your name (costumer): ");
            string user = Console.ReadLine();

            Console.WriteLine($"Hi {user} " + message + "\t : Please see our menu below!\n ");

            //Module 3
            Console.WriteLine(".................................................................\nModule 3 : Desicion Making\n............................................................");

            Console.WriteLine("\n1.) Comparison Operators\n2.) if statement  \n3.) else if statement\n4.) else statement \n5.) Logical operators\n6.)Ternary operator");

            Console.WriteLine("\n*****FOOD MENU*****\n* = Breakfast =  \n* 1.) Cold Cereal\n* 2.) Cottage Cheese\n* 3.)Eggs\n* 4.) Green Tea\n* 5.) Oatmel\n* 6.) Peanut Butter\n*               \n* = Rice Bowl =\n* 7.) Butter Chicken\n* 8.) Chicken Briyani\n* 9.) Briesd Beef Rice\n* 10.) Rice Bowl\n* 11.) Veg Briyani\n* 12.) Plain Rice\n*                      \n* = Salad =\n* 13.)Antipasto Salad\n* 14.) BBQ Pork Salad\n* 15.) Broccolli Rabe\n* 16.) Caesar Salad\n* 17.) Chicken Salad\n* 18.) Crispy Salad\n* 19.) Ponir Mix Salad\n*               \n* = Chicken  =\n* 20.) Finger Chicken\n* 21.) Chicken Grilled\n* 21.) Chicken Grilled with butter\n* 22.) Chicken Wrap\n* 23.) Chicken Marsala\n* 24.) Chicken Francese\n* 25.) Chicken Prame\n*                 \n* = Crezy Beef =\n* 26.) BBQ Beef\n* 27.) Beef Fries\n* 28.) Beef Burger\n* 29.Beef Grilled\n* 30.) Beef Meat\n* 31.) Beef Meat Steak\n* 32.) Beef Bogorok\n*                    \n* = Burger =\n* 33.) Luger Burger\n* 34.) Le Pienon Burger\n* 35.) The Original Burger\n* 36.) Whiskey King Burger\n* 37.) Double Cheese Burger\n* 38.) Deep-Fried Burger\n*           \n*  = Cake =\n* 39.) Black Forest Cake\n* 40.) Pineapple Cake\n* 41.) Eggless Truffle Cake\n* 42.) Coffee Cake with Mocha Frosting\n* 43.) Fudgy Chocolate Cake\n* 44.) Mango Cake\n* 45.) Apple cake\n*                 \n* = Juice =\n* 46.) Lemonade\n* 47.) Apple Juice\n* 48.) Orange Juice\n* 49.) Pineapple Juice\n* 50.) Grape Juice\n*******************");

            Console.WriteLine($"\n{user} enter the number of your order?");
            int order = Convert.ToInt32(Console.ReadLine());
            if (order == 0)
            {
                Console.WriteLine("No Order");
            }
            else if (order >= 1 && order <= 6)
            {
                Console.WriteLine("Breakfast");
            }
            else if (order >= 7 && order <= 12)
            {
                Console.WriteLine("Rice Bowl");
            }
            else if (order >= 13 && order <= 19)
            {
                Console.WriteLine("Salad");
            }
            else if (order >= 20 && order <= 25)
            {
                Console.WriteLine("Chicken");
            }
            else if (order >= 26 && order <= 32)
            {
                Console.WriteLine("Crezy Beef");
            }
            else if (order >= 33 && order <= 38)
            {
                Console.WriteLine("Burger");
            }
            else if (order >= 39 && order <= 45)
            {
                Console.WriteLine("Cake");
            }
            else if (order >= 46 && order <= 50)
            {
                Console.WriteLine("Juice");
            }

            else
            {
                Console.WriteLine("Your order is not in the MENU!");
            }
            Console.WriteLine("Take Out or Dine In or Deliver?: \n 1. Take out \n 2. Dine In\n 3. Deliver\n 4. None");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Wait for 1 minute to take your order\n  THANK YOU FOR ODER {user}!");
                    break;
                case 2:
                    Console.WriteLine($"Wait for 1 minute to serve your order\n THANK YOU FOR ORDER {user}!");
                    break;
                case 3:
                    Console.WriteLine($"Your order deliver soon as possible\n THANK YOU FOR ORDER {user}!");
                    break;

                default:
                    Console.WriteLine("Sad to say your order is not available!");
                    break;

            }
            int mix = 2;
            int max;
            max = (mix > 0) ? 1 : 1;
            Console.WriteLine(max);

            Console.WriteLine(".................................................................\nModule 4: Loops\n.................................................................");
            Console.WriteLine("1.) For Loop\n2.) While Loop \n3.) Break and Continue\n");
            //For Loop
            for (int i = 2; i < 1; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Loop");
            }
            //While loop
            int r = 0;
            while (r < 5)
            {
                Console.WriteLine(r);
                r++;
            }
            //Break and Continue
            for (int i = 2; i <= 10; i++)
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

            Console.WriteLine("...................................................................\nModule 5: Methods\n...................................................................");
            Console.WriteLine("1.) Methods\n2.) Parameters and Arguments \n3.)  Returning from methods");

            static void Welcome()
            {

                Console.WriteLine("My Project is....\nDone!");
                Console.WriteLine("Have a nice day!\nOnce again Leia Rose Undalok");

            }

            static int bday(int year, int age)
            {
                int yourAge = year - age;
                return yourAge;
            }
            int mybday = bday(2023, 20);
            Console.WriteLine($"My Birthyear is {mybday}");
            Welcome();
            static void Paalam(string name)
            {
                Console.WriteLine("Thank " + name);
            }
            Paalam("You!!!");
        }
    }
}




