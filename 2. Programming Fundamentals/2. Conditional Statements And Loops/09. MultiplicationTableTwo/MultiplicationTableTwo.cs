using System;



class MultiplicationTableTwo
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{n} X {m} = {n * m}");
            m++;
        } while (m <= 10);

    }
}

