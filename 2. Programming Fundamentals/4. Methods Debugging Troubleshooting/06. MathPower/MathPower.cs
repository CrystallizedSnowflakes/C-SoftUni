using System;

class MathPower
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        Console.WriteLine(RaiseToPower(number, power));
    }

    static double RaiseToPower(double number, int power)
    {
        double result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        return result;
    }
}

