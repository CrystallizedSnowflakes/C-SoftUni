using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var hours = Console.ReadLine().Split().ToList();
            hours.Sort();
            Console.WriteLine(string.Join(", ", hours));
        }
    }
}
