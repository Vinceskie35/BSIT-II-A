using System;

class RestaurantOrderMenu
{
    static void Main()
    {
        Console.WriteLine("Welcome to George PasPud");

        Console.WriteLine("Hello Come in Customer");

        string restaurantName = "George PasPud";

        double burgerPrice = 58;
        double saladPrice = 35.34;
        double drinkPrice = 25.40;

        int numberOfTables = 10;
        int guestsPerTable = 4;
        int totalGuests = numberOfTables * guestsPerTable;

        Console.WriteLine($"Welcome to {restaurantName}!");
        Console.WriteLine($"Each burger costs {burgerPrice}.");
        Console.WriteLine($"Each salad costs {saladPrice}.");
        Console.WriteLine($"Each drink costs {drinkPrice}.");

        int burgerQuantity = 2;
        double totalBurgerCost = burgerQuantity * burgerPrice;

        int saladQuantity = 1;
        int drinkQuantity = 2;
        double totalSaladCost = saladQuantity * saladPrice;
        double totalDrinkCost = drinkQuantity * drinkPrice;

        Console.Write("How many burgers would you like to order? ");
        burgerQuantity = int.Parse(Console.ReadLine());

        string orderDetails = $"You ordered:\n\t{burgerQuantity} burgers\n\t{saladQuantity} salads\n\t{drinkQuantity} drinks";

        string orderSummary = $"Order Summary:\n"
                              + $"Burgers: {burgerQuantity} x {burgerPrice} = {burgerQuantity * burgerPrice}\n"
                              + $"Salads: {saladQuantity} x {saladPrice} = {saladQuantity * saladPrice}\n"
                              + $"Drinks: {drinkQuantity} x {drinkPrice} = {drinkQuantity * drinkPrice}\n"
                              + $"Total Bill: {totalBurgerCost + totalSaladCost + totalDrinkCost}";

        Console.WriteLine(orderDetails);
        Console.WriteLine(orderSummary);

        int freeBurgerThreshold = 5;
        bool isFreeBurgerAvailable = burgerQuantity >= freeBurgerThreshold;

        if (isFreeBurgerAvailable)
        {
            Console.WriteLine("Congratulations! You've earned a free burger!");
            burgerQuantity++;
        }
        else if (burgerQuantity > 0)
        {
            Console.WriteLine($"You've ordered {burgerQuantity} burgers.");
        }
        else
        {
            Console.WriteLine("You haven't ordered any burgers.");
        }

        bool isSaladIncluded = saladQuantity > 0;
        bool isDrinkIncluded = drinkQuantity > 0;

        if (isSaladIncluded && isDrinkIncluded)
        {
            Console.WriteLine("Great choice! You ordered both a salad and a drink.");
        }
        else if (isSaladIncluded || isDrinkIncluded)
        {
            Console.WriteLine("You ordered either a salad or a drink.");
        }
        else
        {
            Console.WriteLine("Consider adding a salad or a drink to your order.");
        }

        Console.Write("How would you like your burger cooked? (rare, medium, well-done): ");
        string burgerCookingPreference = Console.ReadLine();

        switch (burgerCookingPreference.ToLower())
        {
            case "rare":
                Console.WriteLine("Your rare burger will be cooked to perfection!");
                break;
            case "medium":
                Console.WriteLine("A juicy medium burger coming right up!");
                break;
            case "well-done":
                Console.WriteLine("Well-done it is! Your burger will be thoroughly cooked.");
                break;
            default:
                Console.WriteLine("Sorry, we didn't understand your preference.");
                break;
        }

        string freeBurgerMessage = isFreeBurgerAvailable ? "You've earned a free burger!" : "Keep ordering to earn a free burger.";

        Console.WriteLine("Menu Special: Buy 2 salads, get 1 free drink!");

        int specialSaladQuantity = 2;
        int freeDrinkQuantity = 1;

        for (int i = 0; i < specialSaladQuantity; i++)
        {
            Console.Write($"How many drinks would you like with salad {i + 1}? ");
        }
    }
}
