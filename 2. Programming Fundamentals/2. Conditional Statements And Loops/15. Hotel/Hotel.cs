using System;


namespace _15.Hotel
{
    class Hotel
    {
        static void Main()
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;

            if (nights > 0 && nights <= 7)
            {
                if (mounth == "May" || mounth == "October")
                {
                    priceStudio = 50 * nights;
                    priceDouble = 65 * nights;
                    priceSuite = 75 * nights;
                }
                else if (mounth == "June" || mounth == "September")
                {
                    priceStudio = 60 * nights;
                    priceDouble = 72 * nights;
                    priceSuite = 82 * nights;
                }
                else if (mounth == "July" || mounth == "August" || mounth == "December")
                {
                    priceStudio = 68 * nights;
                    priceDouble = 77 * nights;
                    priceSuite = 89 * nights;
                }
            }
            else if (nights > 7 && nights <= 14)
            {
                if (mounth == "May")
                {
                    priceStudio = 50 * 0.95 * nights;
                    priceDouble = 65 * nights;
                    priceSuite = 75 * nights;
                }
                else if (mounth == "October")
                {
                    priceStudio = 50 * 0.95 * (nights - 1);
                    priceDouble = 65 * nights;
                    priceSuite = 75 * nights;
                }
                else if (mounth == "June")
                {
                    priceStudio = 60 * nights;
                    priceDouble = 72 * nights;
                    priceSuite = 82 * nights;
                }
                else if (mounth == "September")
                {
                    priceStudio = 60 * (nights - 1);
                    priceDouble = 72 * nights;
                    priceSuite = 82 * nights;
                }
                else if (mounth == "July" || mounth == "August" || mounth == "December")
                {
                    priceStudio = 68 * nights;
                    priceDouble = 77 * nights;
                    priceSuite = 89 * nights;
                }
            }
            else if (nights > 14)
            {
                if (mounth == "May" || mounth == "October")
                {
                    priceStudio = 50 * nights;
                    priceDouble = 65 * nights;
                    priceSuite = 75 * nights;
                }
                else if (mounth == "June" || mounth == "September")
                {
                    priceStudio = 60 * nights;
                    priceDouble = 72 * 0.90 * nights;
                    priceSuite = 82 * nights;
                }
                else if (mounth == "July" || mounth == "August" || mounth == "December")
                {
                    priceStudio = 68 * nights;
                    priceDouble = 77 * nights;
                    priceSuite = 89 * 0.85 * nights;
                }
            }
            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
            Console.WriteLine("Double: {0:f2} lv.", priceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", priceSuite);
        }
    }
}
