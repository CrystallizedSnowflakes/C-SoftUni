using System;


namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string firstMetric = Console.ReadLine();
            string secondMetric = Console.ReadLine();

            double valueToMeters = 0;
            double result = 0;

            double millimeters = 1000;
            double centimeters = 100;
            double miles = 0.000621371192;
            double inches = 39.3700787;
            double kilometers = 0.001;
            double feet = 3.2808399;
            double yards = 1.0936133;

            if (firstMetric == "m")
            {
                valueToMeters = value;
            }
            else if (firstMetric == "mm")
            {
                valueToMeters = value / millimeters;
            }
            else if (firstMetric == "cm")
            {
                valueToMeters = value / centimeters;
            }
            else if (firstMetric == "mi")
            {
                valueToMeters = value / miles;
            }
            else if (firstMetric == "in")
            {
                valueToMeters = value / inches;
            }
            else if (firstMetric == "km")
            {
                valueToMeters = value / kilometers;
            }
            else if (firstMetric == "ft")
            {
                valueToMeters = value / feet;
            }
            else if (firstMetric == "yd")
            {
                valueToMeters = value / yards;
            }


            if (secondMetric == "m")
            {
                result = valueToMeters;
            }
            else if (secondMetric == "mm")
            {
                result = valueToMeters * millimeters;
            }
            else if (secondMetric == "cm")
            {
                result = valueToMeters * centimeters;
            }
            else if (secondMetric == "mi")
            {
                result = valueToMeters * miles;
            }
            else if (secondMetric == "in")
            {
                result = valueToMeters * inches;
            }
            else if (secondMetric == "km")
            {
                result = valueToMeters * kilometers;
            }
            else if (secondMetric == "ft")
            {
                result = valueToMeters * feet;
            }
            else if (secondMetric == "yd")
            {
                result = valueToMeters * yards;
            }
            /*if (firstMetric == "m")
            {
                if (secondMetric == "mm")
                {
                    result = value * 1000;
                }
                else if (secondMetric == "km")
                {
                    result = value / 1000;
                }
                else if (secondMetric == "cm")
                {
                    result = value * 100;
                }            
            }
            else if (firstMetric == "mi")
            {
                if (secondMetric == "mm")
                {
                    result = value / 0.000621371192 * 1000;
                }
                else if (secondMetric == "km")
                {
                    result = value / 0.000621371192 / 1000;
                }
                else if (secondMetric == "cm")
                {
                    result = value / 0.000621371192 * 100;
                }
            }*/
            Console.WriteLine(result + " " + secondMetric);
        }
    }
}
