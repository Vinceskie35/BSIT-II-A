//Program Structure
using System;

class StudentAverageApp
{
    static void Main()
    {
      
        Console.WriteLine("Hello! This is the Student's Average App!");

        // Data Types and Variables
        string studentName;
        double testScore1, testScore2, testScore3, averageScore;

        // User Input
        Console.Write("Enter student name: ");
        studentName = Console.ReadLine();

        // While loop
        while (true)
        {
            Console.Write("Enter test score 1: ");
            if (double.TryParse(Console.ReadLine(), out testScore1))
                break; // Exit loop if valid input is provided
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        while (true)
        {
            Console.Write("Enter test score 2: ");
            if (double.TryParse(Console.ReadLine(), out testScore2))
                break; // Exit loop if valid input is provided
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        while (true)
        {
            Console.Write("Enter test score 3: ");
            if (double.TryParse(Console.ReadLine(), out testScore3))
                break; // Exit loop if valid input is provided
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Doing Math
        averageScore = (testScore1 + testScore2 + testScore3) / 3.0;

        // Output
        Console.WriteLine("\nStudent: " + studentName);
        Console.WriteLine("Test Scores: " + testScore1 + ", " + testScore2 + ", " + testScore3);
        Console.WriteLine($"Average Score: {averageScore:F2}");

        IdentifyStudent(averageScore);

        // More on Strings
        string message = "Thank you for using the Student's Average App. Stay sharp!";
        string formattedMessage = $"\nNote: {message}\n\t";
        
        Console.WriteLine(formattedMessage);

    }
    
    // Methods and Parameters
    static void IdentifyStudent(double average)
    {
        // Comparison Operators, if, else-if, else Statements, Logical Operators
        Console.Write("Remarks: ");
        if (average >= 90)
        {
            Console.WriteLine("Excellent");
        }
        else if (average >= 80 && average < 90 || average >= 70 && average != 80) // Logical OR operator
        {
            Console.WriteLine("Good");
        }
        else if (average >= 60 && average != 70) // Logical AND operator and Not Equal operator
        {
            Console.WriteLine("Passed");
        }
        else
        {
            Console.WriteLine("Failed");
        }

        // Switch Statement
        switch ((int)average / 10)
        {
           
            case 9:
                Console.WriteLine("You are an excellent student!");
                break;
            case 8:
                Console.WriteLine("Good Job!");
                break;
            case 7:
                Console.WriteLine("Nice Work!");
                break;
            case 6:
                Console.WriteLine("Grades are satisfying");
                break;
            default:
                Console.WriteLine("Needs Improvement");
                break;                
        }
    }
}
