using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountNumbersDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> uniqueNumbers = new SortedDictionary<int, int>();
            foreach (var num in numbers)
            {
                if (uniqueNumbers.ContainsKey(num))
                {
                    uniqueNumbers[num]++;
                }
                else
                {
                    uniqueNumbers[num] = 1;
                }
            }
            foreach (var num in uniqueNumbers.Keys)
            {
                Console.WriteLine($"{num} -> {uniqueNumbers[num]}");
            }
        }
    }
}
