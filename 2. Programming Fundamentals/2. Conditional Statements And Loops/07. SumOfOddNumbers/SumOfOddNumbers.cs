using System;



class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //var current = 1;
        var sum = 0;
        /*while (n > 0)
        {
            Console.WriteLine(current);
            sum += current;
            n--;
            current = current + 2;
        }
        for (int i = 1; i <= n; i ++)
        {
            int num = i * 2 - 1;
            Console.WriteLine("{0}", num);
            sum += num;
        }
        Console.WriteLine("Sum: " + sum);*/
        for (int i = 1; i <= n * 2 ; i+=2)
        {
            Console.WriteLine("{0}", i);
            sum += i;
        }
        Console.WriteLine("Sum: " + sum);
    }
}

