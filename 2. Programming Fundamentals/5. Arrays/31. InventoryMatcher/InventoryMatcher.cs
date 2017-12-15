using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            string[] quantity = Console.ReadLine().Split(' ');
            string[] price = Console.ReadLine().Split(' ');

            string command = Console.ReadLine();

            while (command != "done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == command)
                    {
                        Console.WriteLine($"{products[i]} costs: {price[i]}; Available quantity: {quantity[i]}");
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
