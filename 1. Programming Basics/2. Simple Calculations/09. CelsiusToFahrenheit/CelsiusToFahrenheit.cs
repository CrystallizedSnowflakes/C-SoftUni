using System;


namespace _09.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            double celcius = double.Parse(Console.ReadLine());

            double toFareinheit = celcius * 1.8 + 32;

            Console.WriteLine("Farenheit: {0:f2}", toFareinheit);
        }
    }
}
