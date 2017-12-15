using System;



class MultiplicationTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        /*for (int i = 1; i <= 10; i++)
         {
             Console.WriteLine($"{n} X {i} = {n * i}");
         }*/
        int counter = 1;
        while (counter <= 10)
        {
            Console.WriteLine($"{n} X {counter} = {n * counter}");
            counter++;
        }
    }
}

