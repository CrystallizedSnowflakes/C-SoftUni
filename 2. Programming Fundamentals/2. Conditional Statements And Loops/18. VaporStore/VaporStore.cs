using System;


namespace _18.VaporStore
{
    class VaporStore
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double currentBalance = money;
            do
            {
                if (game == "OutFall 4")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought OutFall 4");
                        currentBalance -= 39.99;
                    }
                }
                else if (game == "CS: OG")
                {                   
                    if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought CS: OG");
                        currentBalance -= 15.99;
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        currentBalance -= 19.99;
                    }
                }
                else if (game == "Honored 2")
                {
                    if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought Honored 2");
                        currentBalance -= 59.99;
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch");
                        currentBalance -= 29.99;
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        currentBalance -= 39.99;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }               
                if (currentBalance <= 0 )
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();               
            } while (game != "Game Time");
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", money - currentBalance, currentBalance);
        }
    }
}
