using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var @base = int.Parse(numbers[0]); // 7
            BigInteger num = BigInteger.Parse(numbers[1]); // 10

            var result = new StringBuilder();

            while (num > 0)
            {
                var reminder = num % @base; // 3 1
                result.Append(reminder); // 31
                num /= @base; // 1 0
            }
            var reversedResult = new string(result.ToString().Reverse().ToArray()); // 13
            Console.WriteLine(reversedResult);
        }
    }
}
