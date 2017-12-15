using System;

class Program
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine();
        double value = double.Parse(Console.ReadLine());
        switch (imperialUnit)
        {
            case "miles": Console.WriteLine("{0} miles = {1:f2} kilometers", value, value * 1.6); break;
            case "inches": Console.WriteLine("{0} inches = {1:f2} centimeters", value, value * 2.54); break;
            case "feet": Console.WriteLine("{0} feet = {1:f2} centimeters", value, value * 30); break;
            case "yards": Console.WriteLine("{0} yards = {1:f2} meters", value, value * 0.91); break;
            case "gallons": Console.WriteLine("{0} gallons = {1:f2} liters", value, value * 3.8); break;
        }
    }
}

