using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            /*List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> reversedPositive = new List<int>();
            for (int pos = nums.Count - 1; pos >= 0; pos--)
            {
                if (nums[pos] > 0)
                {
                    reversedPositive.Add(nums[pos]);
                }
            }
            if (reversedPositive.Count != 0)
            {
                Console.Write(string.Join(" ", reversedPositive));
            }
            else
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine();*/
            string nums = Console.ReadLine();

            string[] items = nums.Split(' ');

            List<int> reversedPositive = new List<int>();
            for (int pos = items.Length - 1; pos >= 0; pos--)
            {
                int i = int.Parse(items[pos]);
                if (i > 0)
                {
                    reversedPositive.Add(i);
                }
            }
            if (reversedPositive.Count != 0)
            {
                Console.Write(string.Join(" ", reversedPositive));
            }
            else
            {
                Console.WriteLine("empty");
            }
            Console.WriteLine();
        }
    }
}
