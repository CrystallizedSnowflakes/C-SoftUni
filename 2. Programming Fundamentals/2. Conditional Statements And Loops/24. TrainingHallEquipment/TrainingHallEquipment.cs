using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TrainingHallEquipment
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double items = double.Parse(Console.ReadLine());

        double subtotal = 0.0;

        for (int i = 0; i < items; i++)
        {
            string name = Console.ReadLine();
            double priceItem = double.Parse(Console.ReadLine());
            double countItem = double.Parse(Console.ReadLine());
            if (countItem == 1)
            {
                Console.WriteLine($"Adding {countItem} {name} to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {countItem} {name}s to cart.");
            }

            subtotal += priceItem * countItem;
        }
        Console.WriteLine($"Subtotal: ${subtotal:f2}");
        if (subtotal <= budget)
        {
            double moneyLeft = Math.Abs(budget - subtotal);
            Console.WriteLine($"Money left: ${moneyLeft:f2}");
        }
        else
        {
            double moneyNeeded = Math.Abs(subtotal - budget);
            Console.WriteLine($"Not enough. We need ${moneyNeeded:f2} more.");
        }
    }
}

