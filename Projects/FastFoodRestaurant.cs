using System;

class FastFoodRestaurantProgram
{
    static void Main()
    {
        // Program Structure and Output
        Console.WriteLine("Welcome to the Fast Food Restaurant!");

        // Variables and Data Types
        string customerName;
        int burgerQuantity, friesQuantity;
        double burgerPrice = 2.50, friesPrice = 1.50;

        // User Input
        Console.Write("Enter your name: ");
        customerName = Console.ReadLine();

        Console.Write("Enter the quantity of burgers: ");
        string burgerInput = Console.ReadLine();
        Console.Write("Enter the quantity of fries: ");
        string friesInput = Console.ReadLine();

        // Parsing Input
        if (int.TryParse(burgerInput, out burgerQuantity) && int.TryParse(friesInput, out friesQuantity))
        {
            // Doing Math
            double totalBurgerCost = burgerQuantity * burgerPrice;
            double totalFriesCost = friesQuantity * friesPrice;
            double totalPrice = totalBurgerCost + totalFriesCost;

            // Output
            Console.WriteLine($"\nOrder Summary for {customerName}:");
            Console.WriteLine($"Burgers: {burgerQuantity} at ${burgerPrice} each");
            Console.WriteLine($"Fries: {friesQuantity} at ${friesPrice} each");
            Console.WriteLine($"Total Cost: ${totalPrice}");

            // Comparison Operators and if-else Statements
            if (totalPrice > 10)
            {
                Console.WriteLine("Thank you for your large order!");
            }
            else if (totalPrice > 5)
            {
                Console.WriteLine("Enjoy your meal!");
            }
            else
            {
                Console.WriteLine("Would you like to add a drink to your order?");
            }

            // Logical Operators
            bool isSpecialOffer = (burgerQuantity >= 2) && (friesQuantity >= 1);
            Console.WriteLine($"Special Offer: {isSpecialOffer}");

            // switch Statement
            switch (burgerQuantity)
            {
                case 0:
                    Console.WriteLine("No burgers selected.");
                    break;
                case 1:
                    Console.WriteLine("You ordered a burger.");
                    break;
                default:
                    Console.WriteLine($"You ordered {burgerQuantity} burgers.");
                    break;
            }

            // for Loop
            Console.WriteLine("\nThank you for visiting! Here's your receipt:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }

            // while Loop
            Console.WriteLine("\n\nPlease come again! Counting down:");
            int count = 5;
            while (count >= 1)
            {
                Console.Write($"{count} ");
                count--;
            }

            // Methods and Parameters
            DisplayMessage("Thanks for dining at our Fast Food Restaurant!");

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numerical values.");
        }
    }

    // Custom Method with Parameters
    static void DisplayMessage(string message)
    {
        Console.WriteLine($"\n{message}");
    }
}
