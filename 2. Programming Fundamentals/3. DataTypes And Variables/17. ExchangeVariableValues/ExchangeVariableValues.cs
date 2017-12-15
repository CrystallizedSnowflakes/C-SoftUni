using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"Before: \na = 5 \nb = 10 \nAfter: \na = {a} \nb = {b}");
    }
}

