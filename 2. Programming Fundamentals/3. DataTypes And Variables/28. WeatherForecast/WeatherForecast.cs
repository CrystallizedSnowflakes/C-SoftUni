using System;

class WeatherForecast
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());

        if (n % 1 != 0) // (n != (long)n)
        {
            Console.WriteLine("Rainy");
        }
        else if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
        {
            Console.WriteLine("Sunny");
        }
        else if (n >= int.MinValue && n <=int.MaxValue)
        {
            Console.WriteLine("Cloudy");
        }
        else if (n >= long.MinValue && n <= long.MaxValue)
        {
            Console.WriteLine("Windy");
        }
    }
}

