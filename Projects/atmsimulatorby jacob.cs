using System;

namespace ATMProgram
{
    class Program
    {
        static double balance = 1000.0; 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ATM Simulator!");
            while (true)
            {
                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option (1-3): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CheckBalance();
                            break;

                        case 2:
                            Withdraw();
                            break;

                        case 3:
                            Console.WriteLine("Exiting program. Thank you!");
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"\nYour current balance: ${balance}");
        }

        static void Withdraw()
        {
            Console.Write("\nEnter the amount to withdraw: $");

            double withdrawAmount;
            if (double.TryParse(Console.ReadLine(), out withdrawAmount))
            {
                if (withdrawAmount > 0 && withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine($"Withdrawal successful! Remaining balance: ${balance}");
                }
                else if (withdrawAmount > balance)
                {
                    Console.WriteLine("Insufficient funds. Please enter a valid amount.");
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a positive value.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
