using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //[0.....1000]
            var count = new int[1001]; //[nums.Max() + 1] array

            foreach (var num in nums)
            {
                count[num]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine(i + " -> " + count[i]);
                }
            }
        }
    }
}
