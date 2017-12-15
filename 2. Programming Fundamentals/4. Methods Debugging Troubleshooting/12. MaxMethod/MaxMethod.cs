using System;

class MaxMethod
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());

        int firstMax = GetMaxNumber(firstNum, secondNum);
        Console.WriteLine(GetMaxNumber(firstMax, thirdNum)); 
    }

    static int GetMaxNumber(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

