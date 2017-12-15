using System;


namespace _05.TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main()
        {
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
