using System;

namespace BernardsBankProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bernard's Bank Loan \n Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, how can I help you?");
            Console.WriteLine("1. Deposit \n2. Withdraw \n3. Loan \n4. Check Balance \n5. Exit");

            int accountBalance = 0;

            int choice;
            do
            {
                Console.WriteLine("Enter your choice (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Amount to Deposit:");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        if (depositAmount > 0)
                        {
                            accountBalance += depositAmount;
                            Console.WriteLine($"Successfully deposited {depositAmount}. Your new balance is: ${accountBalance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Amount to Withdraw:");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawAmount > 0 && withdrawAmount <= accountBalance)
                        {
                            accountBalance -= withdrawAmount;
                            Console.WriteLine($"Successfully withdrew {withdrawAmount}. Your new balance is: ${accountBalance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdrawal amount. Please enter a valid amount within your balance.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter Loan Amount:");
                        int loanAmount = Convert.ToInt32(Console.ReadLine());
                        if (loanAmount > 0)
                        {
                            Console.WriteLine($"Loan of ${loanAmount} approved. It will be added to your balance.");
                            accountBalance += loanAmount;
                            Console.WriteLine($"Your new balance is: ${accountBalance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid loan amount. Please enter a positive value.");
                        }
                        break;

                    case 4:
                        Console.WriteLine($"Your account balance is: ${accountBalance}");
                        break;

                    case 5:
                        Console.WriteLine("Exiting the program. Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }

            } while (choice != 5);
            Console.WriteLine($"Thank you for using Bernard's Bank Loan {name}, have a good day!");
        }
    }
}
