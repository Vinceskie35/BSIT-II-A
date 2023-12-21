using System;

namespace ATMProgram
{
    class Program
    {
        static double accountBalance = 1000.0; // Initial account balance

        static void Main(string[] args)
        {
            DisplayMenu();

            // Infinite loop to keep the program running until the user chooses to exit
            while (true)
            {
                string choice = GetUserChoice();

                // Process user choice
                switch (choice)
                {
                    case "1":
                        Withdraw();
                        break;

                    case "2":
                        CheckBalance();
                        break;

                    case "3":
                        Deposit();
                        break;

                    case "4":
                        Exit();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                DisplayMenu();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Automated Teller Machine (ATM)");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");
        }

        static string GetUserChoice()
        {
            Console.Write("Enter your choice (1-4): ");
            return Console.ReadLine();
        }

        static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= accountBalance)
            {
                accountBalance -= amount;
                Console.WriteLine($"Withdrawal successful. Remaining balance: {accountBalance:C}");
            }
            else
            {
                Console.WriteLine("Invalid amount or insufficient funds. Please try again.");
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance: {accountBalance:C}");
        }

        static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"Deposit successful. Updated balance: {accountBalance:C}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please try again.");
            }
        }

        static void Exit()
        {
            Console.WriteLine("Thank you for using the ATM. Goodbye!");
            Environment.Exit(0);
        }
    }
}
