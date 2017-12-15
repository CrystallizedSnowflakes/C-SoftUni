using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = Math.Min(n, m); i <= Math.Max(n, m); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
