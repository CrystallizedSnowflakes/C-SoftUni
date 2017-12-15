using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            int length = int.Parse(Console.ReadLine());
            int count = 0;

            List<string> addedIngredients = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == length)
                {
                    count++;
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    addedIngredients.Add(ingredients[i]);
                    if (count == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine("The ingredients are: " + String.Join(", ", addedIngredients) + ".");
        }
    }
}
