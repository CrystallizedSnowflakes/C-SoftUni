using System;


class VaporStoreTwo
{
    static void Main()
    {
        double startingMoney = double.Parse(Console.ReadLine());
        double money = startingMoney;
        string line = Console.ReadLine();

        while (line != "Game Time")
        {
            double gamePrice;
            string gameTitle = string.Empty;
            switch (line)
            {
                case "OutFall 4": gamePrice = 39.99; gameTitle = "OutFall 4"; break;
                case "CS: OG": gamePrice = 15.99; gameTitle = "CS: OG"; break;
                case "Zplinter Zell": gamePrice = 19.99; gameTitle = "Zplinter Zell"; break;
                case "Honored 2": gamePrice = 59.99; gameTitle = "Honored 2"; break;
                case "RoverWatch": gamePrice = 29.99; gameTitle = "RoverWatch"; break;
                case "RoverWatch Origins Edition": gamePrice = 39.99; gameTitle = "RoverWatch Origins Edition"; break;

                default: Console.WriteLine("Not Found");
                    line = Console.ReadLine(); continue;
            }
            if (gamePrice > money)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= gamePrice;
                Console.WriteLine($"Bought {gameTitle}");
            }
            if (money == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            line = Console.ReadLine();
        }
        var remeiningMoney = startingMoney - money;
        Console.WriteLine($"Total spent: ${(remeiningMoney):F2}. Remaining: ${money:F2}");
    }
}

