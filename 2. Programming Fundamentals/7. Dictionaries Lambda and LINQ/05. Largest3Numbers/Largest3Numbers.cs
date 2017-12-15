using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> largestThree = Console.ReadLine().Split().Select(int.Parse).ToList();       

            Console.WriteLine(String.Join(" ", largestThree.OrderBy(x => -x).Take(3)));
        }
    }
}
