using System;


namespace _15.VegetableMarket
{
    class VegetableMarket
    {
        static void Main()
        {
            double priceVegetablesPerKg = double.Parse(Console.ReadLine());
            double priceFruitsPerKg = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            double costsVegetables = priceVegetablesPerKg * kgVegetables;
            double costsFruites = priceFruitsPerKg * kgFruits;

            double total = (costsVegetables + costsFruites) / 1.94;

            Console.WriteLine(total);
        }
    }
}
