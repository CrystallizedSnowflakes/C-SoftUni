using System;

class Program
{
    static void Main()
    {
        char firstBoatCharacter = char.Parse(Console.ReadLine());
        char secondBoatCharacter = char.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        int firstBoatMoves = 0;
        int secondBoatMoves = 0;

        for (int i = 1; i <= n; i++)
        {
            string sentence = Console.ReadLine();
            int tiles = sentence.Length;
            if (sentence == "UPGRADE")
            {
                firstBoatCharacter += (char)3;
                secondBoatCharacter += (char)3;
            }
            else
            {
                if (i % 2 == 1)
                {
                    firstBoatMoves += tiles;
                    if (firstBoatMoves >= 50)
                    {
                        break;
                    }
                }
                else
                {
                    secondBoatMoves += tiles;
                    if (secondBoatMoves >= 50)
                    {
                        break;
                    }
                }
            }            
        }
        Console.WriteLine(firstBoatMoves > secondBoatMoves ? firstBoatCharacter : secondBoatCharacter);
    }
}

