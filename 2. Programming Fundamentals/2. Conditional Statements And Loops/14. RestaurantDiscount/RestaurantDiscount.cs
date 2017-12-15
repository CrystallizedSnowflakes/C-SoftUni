using System;



class RestaurantDiscount
{
    static void Main()
    {
        int group = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();
        string hallName = "";
        double price = 0.0;
        double discount = 0.0;

        if (group >= 0 && group <= 50)
        {
            hallName = "Small Hall";
            if (package == "Normal")
            {
                price = 2500 + 500;
                discount = price * 0.05;
                price = (price - discount) / group;
            }
            else if (package == "Gold")
            {
                price = 2500 + 750;
                discount = price * 0.10;
                price = (price - discount) / group;
            }
            else if (package == "Platinum")
            {
                price = 2500 + 1000;
                discount = price * 0.15;
                price = (price - discount) / group;
            }
        }
        else if (group > 50 && group <= 100)
        {
            hallName = "Terrace";
            if (package == "Normal")
            {
                price = 5000 + 500;
                discount = price * 0.05;
                price = (price - discount) / group;
            }
            else if (package == "Gold")
            {
                price = 5000 + 750;
                discount = price * 0.10;
                price = (price - discount) / group;
            }
            else if (package == "Platinum")
            {
                price = 5000 + 1000;
                discount = price * 0.15;
                price = (price - discount) / group;
            }
        }
        else if (group > 100 && group <= 120)
        {
            hallName = "Great Hall";
            if (package == "Normal")
            {
                price = 7500 + 500;
                discount = price * 0.05;
                price = (price - discount) / group;
            }
            else if (package == "Gold")
            {
                price = 7500 + 750;
                discount = price * 0.10;
                price = (price - discount) / group;
            }
            else if (package == "Platinum")
            {
                price = 7500 + 1000;
                discount = price * 0.15;
                price = (price - discount) / group;
            }
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }
        Console.WriteLine($"We can offer you the {hallName}");
        Console.WriteLine("The price per person is {0:f2}$", price);
    }
}

