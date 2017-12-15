using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squares = new List<int>();
            foreach (var num in nums)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num)) // equals to cqlo 4islo
                {
                    squares.Add(num);
                }
                squares.Sort();
                squares.Reverse();
            }
            Console.Write(string.Join(" ", squares));
            Console.WriteLine();
        }
    }
}
