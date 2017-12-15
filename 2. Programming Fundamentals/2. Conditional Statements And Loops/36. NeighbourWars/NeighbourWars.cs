using System;

class NeighbourWars
{
    static void Main()
    {
        int damagePesho = int.Parse(Console.ReadLine());
        int damageGosho = int.Parse(Console.ReadLine());

        int pointsPesho = 100;
        int pointsGosho = 100;

        int turns = 1;

        while (pointsPesho > 0 || pointsGosho > 0 )
        {
            if (turns % 2 == 0)
            {
                pointsPesho -= damageGosho;
                if (pointsPesho > 0)
                {
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {pointsPesho} health.");
                }
                else
                {
                    Console.WriteLine($"Gosho won in {turns}th round.");
                    break;
                }
            }
            else
            {
                pointsGosho -= damagePesho;
                if (pointsGosho > 0)
                {
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {pointsGosho} health.");
                }
                else
                {
                    Console.WriteLine($"Pesho won in {turns}th round.");
                    break;
                }
            }
            if (turns % 3 == 0)
            {
                pointsPesho += 10;
                pointsGosho += 10;
            }
            turns++;
        }
    }
}

