using System;


namespace _04.FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            if (input == "banana" || input == "lemon" ||
                input == "apple" || input == "kiwi" ||
                input == "cherry" || input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (input == "tomato" || input == "cucumber" ||
                input == "pepper" || input == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
