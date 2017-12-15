using System;

class HouseBuilder
{
    static void Main()
    {
        long firstPrice = long.Parse(Console.ReadLine());
        long secondPrice = long.Parse(Console.ReadLine());

        byte bytePrice = 0;
        long intPrice = 0;
        if (firstPrice > secondPrice)
        {
            bytePrice = (byte)secondPrice;
            intPrice = firstPrice;
        }
        else
        {
            bytePrice = (byte)firstPrice;
            intPrice = secondPrice;
        }
        //Console.WriteLine(bytePrice * 4 + intPrice * 10); //????

        int roof = bytePrice * 4;
        Console.WriteLine(roof);
        long body = intPrice * 10;
        Console.WriteLine(body);
        long house = roof + body;
        Console.WriteLine(house);
    }
}

