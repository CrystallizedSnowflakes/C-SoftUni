using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CountNumbersTwo
{
    class CountNumbersTwo
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //[0.....1000]
            nums.Sort();
            var count = 1;
            for (int pos = 0; pos < nums.Count; pos++)
            {
                int num = nums[pos];
                if (pos < nums.Count - 1 &&  // current pos < last pos AND
                    nums[pos] != nums[pos + 1] || // element on pos != next element
                    pos == nums.Count - 1) // current pos == last pos
                {
                    Console.WriteLine($"{num} -> {count}");
                    count = 0;
                }
                count++;
            }
        }
    }
}
