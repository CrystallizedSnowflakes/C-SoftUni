using System;


namespace _10.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string projectionType = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());

            double result = 0.0;

            if (projectionType == "Premiere")
            {
                result = rows * cols * 12.00;
                Console.WriteLine("{0:f2} \nleva", result);
            }
            else if (projectionType == "Normal")
            {
                result = rows * cols * 7.50;
                Console.WriteLine("{0:f2} \nleva", result);
            }
            else if (projectionType == "Discount")
            {
                result = rows * cols * 5.00;
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
