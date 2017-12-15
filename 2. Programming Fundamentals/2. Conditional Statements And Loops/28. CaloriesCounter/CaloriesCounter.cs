using System;

class CaloriesCounter
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int cheese = 500;
        int tomatoSauce = 150;
        int salami = 600;
        int pepper = 50;
        int calories = 0;

        for (int i = 0; i < number; i++)
        {
            string ingredient = Console.ReadLine().ToLower();
            switch (ingredient)
            {
                case "cheese": calories += cheese; break;
                case "tomato sauce": calories += tomatoSauce; break;
                case "salami": calories += salami; break;
                case "pepper": calories += pepper; break;
                default: continue;
            }
        }
        Console.WriteLine($"Total calories: {calories}");
    }
}

