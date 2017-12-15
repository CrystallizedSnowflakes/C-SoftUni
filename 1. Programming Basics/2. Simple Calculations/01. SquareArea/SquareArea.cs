using System;


namespace _01.SquareArea
{
    class SquareArea
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a * a);
            /*Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(":)");*/
            Console.WriteLine(Math.Pow(a, 2));
        }
    }
}
