using System;

namespace MarkoHanginonAverage{

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Marko's Student Average Calculator!");

        Console.WriteLine("This program will help you calculate the average of three student scores.");

        int score1, score2, score3;
        int totalScore;
        double averageScore;

        Console.Write("Enter score 1: ");
        score1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter score 2: ");
        score2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter score 3: ");
        score3 = Convert.ToInt32(Console.ReadLine());

        totalScore = score1 + score2 + score3;
        averageScore = CalculateAverage(score1, score2, score3);

        Console.Write("\nEnter your name: ");
        string studentName = Console.ReadLine();

        Console.WriteLine($"\nHello, {studentName}!\n");

        Console.WriteLine("Results:");
        Console.WriteLine("Total Score: " + totalScore);
        Console.WriteLine($"Average Score: {averageScore:F2}");

        if (averageScore >= 90)
        {
            Console.WriteLine("Congratulations! You have an A grade.");
        }

        if (averageScore >= 60)
        {
            Console.WriteLine("You passed the course!");
        }
        else if (averageScore >= 40)
        {
            Console.WriteLine("You need improvement, but you passed.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course.");
        }

        bool isHighScore = totalScore > 250;
        bool isGoodAttendance = true;

        if (isHighScore && isGoodAttendance)
        {
            Console.WriteLine("You achieved a high score and had good attendance!");
        }

        switch (totalScore)
        {
            case int n when (n >= 250):
                Console.WriteLine("You scored exceptionally well!");
                break;
            case int n when (n >= 200):
                Console.WriteLine("You scored well!");
                break;
            case int n when (n >= 150):
                Console.WriteLine("You passed!");
                break;
            default:
                Console.WriteLine("You need improvement.");
                break;
        }

        string resultMessage = (averageScore >= 60) ? "You passed!" : "You did not pass.";
        Console.WriteLine(resultMessage);

        Console.WriteLine("\nUsing for loop to display scores:");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Score {i}: {score1}");
        }

        int counter = 1;
        Console.WriteLine("\nUsing while loop to display scores:");
        while (counter <= 3)
        {
            Console.WriteLine($"Score {counter}: {score2}");
            counter++;
        }

        Console.WriteLine("\nAverage calculated using a method: " + averageScore);

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    static double CalculateAverage(int s1, int s2, int s3)
    {
        return (s1 + s2 + s3) / 3.0;
    }
}
}
