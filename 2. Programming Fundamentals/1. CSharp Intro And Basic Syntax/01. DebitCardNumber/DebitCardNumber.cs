using System;



class DebitCardNumber
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("{0:D4} {1:D4} {2:d4} {3:D4}", num1, num2, num3, num4);
    }
}

