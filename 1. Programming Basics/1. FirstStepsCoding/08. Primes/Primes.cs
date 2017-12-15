using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Primes
{
    class Primes
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.Write(" " + num);
                }
            }
        }
    }
}
