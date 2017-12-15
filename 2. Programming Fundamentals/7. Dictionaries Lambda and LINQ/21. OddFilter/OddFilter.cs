using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            var evenNums = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToList();
            double average = evenNums.Average();
            var result = evenNums.Select(x => x < average ? x-1 : x+1).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
