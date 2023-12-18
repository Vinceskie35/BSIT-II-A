using System;

namespace Renrensimcard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Renren Simcard Service \nEnter Your Name");
            string name = Console.ReadLine();
            int choice;

            do
            {
                Console.WriteLine($"HI {name} Enter Your Simcard");
                Console.WriteLine("1. Globe \n2. Smart \n3. TNT \n4. TM \n5. Out");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Welcome to Globe, Check out the offers\n1. Buy Load \n2. Register \n3. Out");
                        int globeOption = Convert.ToInt32(Console.ReadLine());

                        switch (globeOption)
                        {
                            case 1:
                                Console.WriteLine("Enter amount to buy load for Globe:");
                                int globeAmount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"You have successfully bought {globeAmount} load for Globe. Thank you!");
                                break;

                            case 2:
                                Console.WriteLine("Register Globe");
                                Console.WriteLine("Enter Amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Succesfully registered php{amount}");
                                break;

                            case 3:
                                Console.WriteLine("Exiting Globe menu");
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please choose a valid option.");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Welcome to Smart, Check out the offers\n1. Buy Load \n2. Register \n3. Out");
                        int smartOption = Convert.ToInt32(Console.ReadLine());

                        switch (smartOption)
                        {
                            case 1:
                                Console.WriteLine("Enter amount to buy load for Smart:");
                                int smartAmount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"You have successfully bought {smartAmount} load for Smart. Thank you!");
                                break;

                            case 2:
                                Console.WriteLine("Register Smart");
                                Console.WriteLine("Enter Amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Succesfully registered php{amount}"); 
                                break;

                            case 3:
                                Console.WriteLine("Exiting Smart menu");
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please choose a valid option.");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Welcome to TNT, Check out the offers\n1. Buy Load \n2. Register \n3. Out");
                        int tntOption = Convert.ToInt32(Console.ReadLine());

                        switch (tntOption)
                        {
                            case 1:
                                Console.WriteLine("Enter amount to buy load for TNT:");
                                int tntAmount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"You have successfully bought {tntAmount} load for TNT. Thank you!");
                                break;

                            case 2:
                                Console.WriteLine("RegisterTNT");
                                Console.WriteLine("Enter Amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Succesfully registered php{amount}");
                                break;

                            case 3:
                                Console.WriteLine("Exiting TNT menu");
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please choose a valid option.");
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Welcome to TM, Check out the offers\n1. Buy Load \n2. Register \n3. Out");
                        int tmOption = Convert.ToInt32(Console.ReadLine());

                        switch (tmOption)
                        {
                            case 1:
                                Console.WriteLine("Enter amount to buy load for TM:");
                                int tmAmount = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"You have successfully bought {tmAmount} load for TM. Thank you!");
                                break;

                            case 2:
                                Console.WriteLine("Register TM");
                                Console.WriteLine("Enter Amount:");
                                double amount = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Succesfully registered php{amount}");
                                break;

                            case 3:
                                Console.WriteLine("Exiting TM menu");
                                break;

                            default:
                                Console.WriteLine("Invalid option. Please choose a valid option.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Thank you for choosing Renren SimCard Services");
                        break;
                }
            } while (choice != 5);
        }
    }
}
