using System;

namespace TemperaturebyGonzalesLuke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Program");

            // Variables and Data Types
            double temperature;
            string temperatureType;

            // User Input
            Console.Write("Enter the temperature: ");
            temperature = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the temperature type (C for Celsius, F for Fahrenheit): ");
            temperatureType = Console.ReadLine().ToUpper();

            // Converting temperatures
            double convertedTemp = 0;

            if (temperatureType == "C")
            {
                convertedTemp = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"{temperature}°C is equal to {convertedTemp}°F");
            }
            else if (temperatureType == "F")
            {
                convertedTemp = FahrenheitToCelsius(temperature);
                Console.WriteLine($"{temperature}°F is equal to {convertedTemp}°C");
            }
            else
            {
                Console.WriteLine("Invalid temperature type entered.");
                return;
            }

            // Method to convert Celsius to Fahrenheit
            static double CelsiusToFahrenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }

            // Method to convert Fahrenheit to Celsius
            static double FahrenheitToCelsius(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9;
            }

            string message = "Thank you for using the LUKE'S Temperature Program!";
            Console.WriteLine("\n" + message + "\n");

            // Concatenation and Interpolation
            string appName = "Temperature Program";
            int version = 1;
            Console.WriteLine($"[{appName}] Version {version}");

            // Comparison Operators
            if (convertedTemp > 80)
            {
                Console.WriteLine("The temperature is hot.");
            }
            else if (convertedTemp < 50)
            {
                Console.WriteLine("The temperature is cold.");
            }
            else
            {
                Console.WriteLine("The temperature is moderate.");
            }

            // Logical Operators
            bool isHigh = convertedTemp > 90;
            bool isLow = convertedTemp < 32;

            if (isHigh || isLow)
            {
                Console.WriteLine("Extreme temperature detected.");
            }
            else if (convertedTemp >= 60 && convertedTemp <= 80)
            {
                Console.WriteLine("The temperature is comfortable.");
            }
            else
            {
                Console.WriteLine("Reset it and Try again!");
            }

            // Switch Statement
            switch (temperatureType)
            {
                case "C":
                    Console.WriteLine("You entered Celsius.");
                    break;
                case "F":
                    Console.WriteLine("You entered Fahrenheit.");
                    break;
                default:
                    Console.WriteLine("Unknown temperature type.");
                    break;
            }

            

            Console.WriteLine("\nProgram execution complete./ if you have any problem sorry because the programmer is a begginer hehehe ");
        }
    }
}