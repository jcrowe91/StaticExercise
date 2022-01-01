using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = TempConverter.CelsiusToFahrenheit(50);
            double fahrenheit = TempConverter.FahrenheitToCelsius(100);

            Console.WriteLine($"Celsius: {celsius}!");
            Console.WriteLine($"Fahrenheit: {fahrenheit}!");
        }



    }
}
