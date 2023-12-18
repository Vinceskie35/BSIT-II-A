using System;

class AgeIdentifier
{
    static void Main()
    {
        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine("Welcome to Myca's Age Identifier program!");
         Console.WriteLine("---------------------------------------");

        Console.Write("Enter the current year: ");
        int currentYear = int.Parse(Console.ReadLine());

        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int age = currentYear - birthYear;

        Console.WriteLine($"Your age is: {age}");

        if (age >= 0 && age <= 5)
        {
            Console.WriteLine("You are a toddler.");
        }
        else if (age >= 6 && age <= 12)
        {
            Console.WriteLine("You are a child.");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("You are a teenager.");
        }
        else
        {
            Console.WriteLine("You are an adult.");
        }

        Console.WriteLine("Printing numbers from 1 to 5 using a for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("choice your city: \n1.Cebu City \n2.Mandaue City \n3.Lapulapu City \n4.Toledo City \n5.Naga City ");
        int city = int.Parse(Console.ReadLine());

        switch (city)
        {
            case 1:
                Console.WriteLine("You are from Cebu City!");
                break;
            case 2:
                Console.WriteLine("You are from Mandaue City!");
                break;
            case 3:
                Console.WriteLine("You are from Lapulapu City!");
                break;
            case 4:
                Console.WriteLine("You are from Toledo City!");
                break;
            case 5:
                Console.WriteLine("You are from Naga City!");
                break;
            default:
                Console.WriteLine("Invalid city");
                break;
        }

        Console.ReadLine(); // Keep the console window open
    }
}
