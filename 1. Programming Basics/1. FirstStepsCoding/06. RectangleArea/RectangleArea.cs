using System;


namespace _06.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());

            var area = a * b;

            if ( area > 0 )
                {
                Console.WriteLine(area);
                }
            else
                Console.WriteLine("Put a number bigger than 0");
        }
    }
}
