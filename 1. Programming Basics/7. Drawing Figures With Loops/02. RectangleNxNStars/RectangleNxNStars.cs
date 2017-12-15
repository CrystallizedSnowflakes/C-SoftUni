using System;
using System.Text;

namespace _02.RectangleNxNStars
{
    class RectangleNxNStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder yes = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                yes.Append('*', n).AppendLine();

                //Console.WriteLine(new string('*', n));
            }
            Console.WriteLine(yes);
        }
    }
}
