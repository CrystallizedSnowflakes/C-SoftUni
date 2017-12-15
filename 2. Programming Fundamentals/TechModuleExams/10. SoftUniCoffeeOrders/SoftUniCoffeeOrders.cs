using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int quantity = int.Parse(Console.ReadLine());

                var coffeePrice = pricePerCapsule * quantity * DateTime.DaysInMonth(date.Year, date.Month);
                //the DateTime class may come in handy to calculate the days in certain month
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
                total += coffeePrice;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
