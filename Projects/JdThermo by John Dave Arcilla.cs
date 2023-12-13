using System;

namespace JdThermo
{
    class Program
    {
        static void DisplayComparison(double temp1, double temp2)
        {
            Console.WriteLine($"\nComparison of Temperatures:");
            Console.WriteLine($"Is {temp1} greater than {temp2}? {temp1 > temp2}");
        }

        static string GetTemperatureStatus(double temp)
        {
            if (temp > 30)
            {
                return "hot";
            }
            else if (temp > 10)
            {
                return "cool";
            }
            else
            {
                return "cold";
            }
        }

        static void Main()
        {
            Console.WriteLine("Final Project \n");
            Console.WriteLine("Jd Thermometer!");

            double tempC;
            double tempF;

            Console.Write("\nEnter temperature in Celsius: ");
            tempC = Convert.ToDouble(Console.ReadLine());

            tempF = (tempC * 9 / 5) + 32;

            Console.WriteLine($"\nTemperature in Fahrenheit: {tempF} °F");

            Console.Write("\nEnter temperature in Fahrenheit: ");
            double tempInF = Convert.ToDouble(Console.ReadLine());
            double tempInC = (tempInF - 32) * 5 / 9;
            Console.WriteLine($"\nTemperature in Celsius: {tempInC} °C");

            DisplayComparison(tempC, tempInC);

            Console.WriteLine($"\nTemperature Display:");
            Console.WriteLine($"Current temperature: {tempC} °C");
            Console.WriteLine($"Current temperature: {tempF} °F");

            Console.Write("\nEnter a temperature in Celsius: ");
            double userTempC = Convert.ToDouble(Console.ReadLine());
            double userTempF = (userTempC * 9 / 5) + 32;
            Console.WriteLine($"\nTemperature in Fahrenheit: {userTempF} °F");

            string fRead = $"Temperature: {tempC:F2} °C / {tempF:F2} °F";
            Console.WriteLine($"\nReading:\n{fRead}");

            if (userTempC > 0)
            {
                Console.WriteLine("\nTemperature is above freezing point.");
            }

            if (userTempC > 30)
            {
                Console.WriteLine("It's so init today!!");
            }

            else if (userTempC > 10)
            {
                Console.WriteLine("Chill day.");
            }

            else
            {
                Console.WriteLine("Katugnaw baya!");
            }

            bool isTemperatureInRange = userTempC >= 0 && userTempC <= 30;
            bool isNotExtremeHot = userTempC < 40 || userTempF < 100;

            if (isTemperatureInRange && isNotExtremeHot)
            {
                Console.WriteLine("The temperature is in the comfortable range.");
            }

            switch (userTempC)
            {
                case var _ when userTempC < 0:
                    Console.WriteLine("It's freezing cold :( !");
                    break;
                case var _ when userTempC > 30:
                    Console.WriteLine("It's very init >:( !");
                    break;
                default:
                    Console.WriteLine("The temperature is chill :) .");
                    break;
            }

            Console.WriteLine("\nCountdown:");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"Temperature is cooling down: {i}");
            }

            Console.WriteLine("\nCountdown:");
            int count = 10;
            while (count >= 1)
            {
                Console.WriteLine($"Temperature is still dropping: {count}");
                count--;
            }

            string tempStatus = GetTemperatureStatus(userTempC);
            Console.WriteLine($"\nTemperature Status: It's a {tempStatus} day!");

            DisplayComparison(userTempC, tempInC);

            Console.WriteLine("\nThank you for using Jd Thermometer :) !");
        }
    }
}
