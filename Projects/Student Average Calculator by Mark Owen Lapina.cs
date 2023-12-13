using System;

namespace Lapinastudentaverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Average Calculator!");
            Console.WriteLine("This program will help you calculate the average of three student scores.");

            int score1, score2, score3;

            
            Console.WriteLine("Enter score 1:");
            score1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter score 2:");
            score2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter score 3:");
            score3 = Convert.ToInt32(Console.ReadLine());

            double average = CalculateAverage(score1, score2, score3);

            Console.WriteLine($"\nThe calculated average is: {average}");

            average += 5; 

            Console.WriteLine($"\nThe initial average of the three scores + 5 is: {average}");

            Console.WriteLine("\nSome text with a newline\nand a tab after this\ttabbed text.");

            string message = "The average of scores is: " + average; 
            string interpolatedMessage = $"The calculated average is: {average}"; 

            Console.WriteLine("\nConcatenated message: " + message);
            Console.WriteLine("Interpolated message: " + interpolatedMessage);

           
            if (average >= 60)
            {
                Console.WriteLine("\nThe student has passed.");
            }
            else if (average >= 40 && average < 60)
            {
                Console.WriteLine("\nThe student is on probation.");
            }
            else
            {
                Console.WriteLine("\nThe student has failed.");
            }

            bool highScore = score1 > 90 || score2 > 90 || score3 > 90;

            if (highScore)
            {
                Console.WriteLine("\nThe student achieved a high score in at least one test.");
            }

            char grade;

            switch ((int)average / 10)
            {
                case 10:
                case 9:
                    grade = 'A';
                    break;
                case 8:
                    grade = 'B';
                    break;
                case 7:
                    grade = 'C';
                    break;
                case 6:
                    grade = 'D';
                    break;
                default:
                    grade = 'F';
                    break;
            }

            Console.WriteLine($"\nThe student's grade is: {grade}");

            string passStatus = average >= 40 ? "Pass" : "Fail";

            Console.WriteLine($"\nThe student's pass status: {passStatus}");

            Console.WriteLine("\nCounting from 1 to 10 using a for loop:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nEven numbers between 1 and 10 using a while loop with break and continue:");
            int num = 1;
            while (num <= 10)
            {
                if (num % 2 != 0)
                {
                    num++;
                    continue;
                }

                if (num > 6)
                {
                    break;
                }

                Console.Write(num + " ");
                num++;
            }

            
            Console.WriteLine("\n\nMethods:");

            static double CalculateAverage(int score1, int score2, int score3)
            {
                return (score1 + score2 + score3) / 3.0;
            }

           
            static void DisplayStudentStatus(double avg)
            {
                if (avg >= 60)
                {
                    Console.WriteLine("\nThe student has passed.");
                }
                else if (avg >= 40 && avg < 60)
                {
                    Console.WriteLine("\nThe student is on probation.");
                }
                else
                {
                    Console.WriteLine("\nThe student has failed.");
                }
            }

            
            static void DisplayGrade(double avg)
            {
                char grade;

                switch ((int)avg / 10)
                {
                    case 10:
                    case 9:
                        grade = 'A';
                        break;
                    case 8:
                        grade = 'B';
                        break;
                    case 7:
                        grade = 'C';
                        break;
                    case 6:
                        grade = 'D';
                        break;
                    default:
                        grade = 'F';
                        break;
                }

                Console.WriteLine($"\nThe student's grade is: {grade}");
            }
   
            DisplayStudentStatus(average);
            DisplayGrade(average);

            Console.WriteLine("\nThank you for using the Student Average Calculator!");
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey(); 
        }
    }
}
