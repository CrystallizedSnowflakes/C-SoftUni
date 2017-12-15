using System;


namespace _01.RectangleTenXTenStars
{
    class RectangleTenXTenStars
    {
        static void Main()
        {
            for (int row = 1; row <= 10; row++)
            {
                //Console.WriteLine(new string('*', 10));
                for (int col = 0; col < 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
