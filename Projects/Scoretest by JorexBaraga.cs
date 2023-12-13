using System;

namespace ScorebyJorexBaraga
{

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to the Score Calculator!");


            int totalScore = 0;


            Console.Write("Enter the score for Assignment 1: ");
            int assignment1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score for Assignment 2: ");
            int assignment2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score for Midterm Exam: ");
            int midtermExam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the score for Final Exam: ");
            int finalExam = Convert.ToInt32(Console.ReadLine());


            totalScore = assignment1 + assignment2 + midtermExam + finalExam;


            Console.WriteLine($"\nTotal Score: {totalScore}");


            int passingScore = 60;

            if (totalScore >= passingScore)
            {
                Console.WriteLine("Congratulations! You passed.");
            }
            else
            {
                Console.WriteLine("Sorry, you did not pass. Better luck next time.");
            }
        }
    }
}
