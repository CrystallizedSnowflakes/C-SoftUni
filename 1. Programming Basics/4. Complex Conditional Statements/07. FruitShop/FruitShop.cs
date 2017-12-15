using System;


namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string product = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;
            bool validInput = true;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (product == "banana")
                {
                    price = 2.5;
                }
                else if (product == "apple")
                {
                    price = 1.2;
                }
                else if (product == "orange")
                {
                    price = 0.85;
                }
                else if (product == "grapefruit")
                {
                    price = 1.45;
                }
                else if (product == "kiwi")
                {
                    price = 2.7;
                }
                else if (product == "pineapple")
                {
                    price = 5.5;
                }
                else if (product == "grapes")
                {
                    price = 3.85;
                }
                else
                {
                    validInput = false;
                }
            }
            else if (day == "saturday" || day == "sunday")
            {
                if (product == "banana")
                {
                    price = 2.7;
                }
                else if (product == "apple")
                {
                    price = 1.25;
                }
                else if (product == "orange")
                {
                    price = 0.90;
                }
                else if (product == "grapefruit")
                {
                    price = 1.60;
                }
                else if (product == "kiwi")
                {
                    price = 3;
                }
                else if (product == "pineapple")
                {
                    price = 5.6;
                }
                else if (product == "grapes")
                {
                    price = 4.20;
                }
                else
                {
                    validInput = false;
                }            
            }
            else
            {
                validInput = false;
            }

            if (validInput)
            {
                Console.WriteLine("{0:f2}", quantity * price);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
