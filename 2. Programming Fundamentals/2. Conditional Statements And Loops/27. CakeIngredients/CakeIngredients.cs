using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            string ingredient = Console.ReadLine();
            int count = 0;
            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
                ingredient = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
