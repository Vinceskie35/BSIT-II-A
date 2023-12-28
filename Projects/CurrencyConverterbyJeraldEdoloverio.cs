using System;

class CurrencyConverter
{
    static void Main()
    {
        double usdToPhpRate = 50.0;

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your birthday (YYYY-MM-DD): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
        {
            int age = CalculateAge(birthday);

            Console.Write("Enter the amount in USD: ");
            if (double.TryParse(Console.ReadLine(), out double usdAmount))
            {
                double phpAmount = ConvertUsdToPhp(usdAmount, usdToPhpRate);

                Console.WriteLine($"{userName}, aged {age}, born on {birthday.ToShortDateString()},");
                Console.WriteLine($"{usdAmount} USD is equal to {phpAmount} PHP at the rate of {usdToPhpRate}.");
            }
            else
            {
                Console.WriteLine("Invalid input for USD amount. Please enter a valid number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for birthday. Please enter a valid date in the format YYYY-MM-DD.");
        }
    }

    static double ConvertUsdToPhp(double usdAmount, double rate)
    {
        return usdAmount * rate;
    }

    static int CalculateAge(DateTime birthday)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthday.Year;

        if (today < birthday.AddYears(age))
        {
            age--;
        }

        return age;
    }
}
