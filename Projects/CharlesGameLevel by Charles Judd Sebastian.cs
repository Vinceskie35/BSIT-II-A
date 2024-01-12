using System;

class CharlesGameLevel
{
    static void Main()
    {
        Console.WriteLine("Welcome Mobile Mobile!");

        Console.WriteLine("Welcome Hero");

        int playerScore = 100;
        Console.WriteLine($"Player Score: {playerScore}");

        string playerName = "Player1";
        float playerHealth = 75.5f;
        Console.WriteLine($"Player Name: {playerName}, Player Health: {playerHealth}");

        int num1 = 20;
        int num2 = 8;
        int result = num1 + num2;
        Console.WriteLine($"Sum of {num1} and {num2} is: {result}");

        int product = num1 * num2;
        Console.WriteLine($"Product of {num1} and {num2} is: {product}");

        playerScore += 10;
        Console.WriteLine($"Updated Player Score: {playerScore}");

        Console.Write("Enter your player name: ");
        string userInputName = Console.ReadLine();
        Console.WriteLine($"Hello, {userInputName}!");

        string levelName = "Castle";
        int levelNumber = 3;
        string levelDescription = $"Welcome to {levelName} Level {levelNumber}! " +
                                  $"Your goal is to defeat the enemies and reach the exit.";
        Console.WriteLine(levelDescription);

        if (playerScore > 150)
        {
            Console.WriteLine("You have a high score!");
        }
        else if (playerScore > 100)
        {
            Console.WriteLine("You have a good score.");
        }
        else
        {
            Console.WriteLine("Keep playing to improve your score!");
        }

        bool isPlayerAlive = playerHealth > 0;
        bool isPlayerStrong = playerScore > 80;

        if (isPlayerAlive && isPlayerStrong)
        {
            Console.WriteLine("You are alive and strong!");
        }

        string playerStatus = "Normal";

        switch (playerStatus)
        {
            case "Normal":
                Console.WriteLine("You are in a normal state.");
                break;
            case "Injured":
                Console.WriteLine("You are injured. Use a health potion!");
                break;
            case "Poisoned":
                Console.WriteLine("You are poisoned. Find an antidote!");
                break;
            default:
                Console.WriteLine("Unknown player status.");
                break;
        }

        Console.WriteLine("Counting from 1 to 5 to start the game:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        int enemyCount = 5;
        int defeatedEnemies = 0;

        while (defeatedEnemies < enemyCount)
        {
            Console.WriteLine($"Defeated enemies: {defeatedEnemies}");

            Console.Write("Continue attacking? (yes/no): ");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "yes")
            {
                defeatedEnemies++;
            }
            else if (userChoice.ToLower() == "no")
            {
                Console.WriteLine("You decided to stop attacking.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'yes' or 'no'.");
                continue;
            }
        }

        int multipliedResult = MultiplyNumbers(num1, num2);
        Console.WriteLine($"Result of multiplication using a method: {multipliedResult}");

        int damageDealt = CalculateDamage(20, 5);
        Console.WriteLine($"You dealt {damageDealt} damage to the enemy!");
    }

    static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }

    static int CalculateDamage(int baseDamage, int enemyDefense)
    {
        int damageDealt = baseDamage - enemyDefense;
        return damageDealt > 0 ? damageDealt : 0;
    }
}
