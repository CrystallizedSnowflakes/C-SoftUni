using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            long power = long.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            double fiftyPercentOfPower = (double)power / 2;
            var count = 0;
            while (power >= distance)
            {
                power -= distance;
                count++;
                if (power == fiftyPercentOfPower && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;
                    if (power < distance)
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(Math.Floor((double)power));
            Console.WriteLine(count);
        }
    }
}
