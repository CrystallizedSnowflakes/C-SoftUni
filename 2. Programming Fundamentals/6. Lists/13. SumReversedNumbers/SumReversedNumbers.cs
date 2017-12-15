using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.ReadLine().Split().Select(str => int.Parse(new string(str.Reverse().ToArray()))).Sum());
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                var currentNum = arr[i];
                var currentNumToStr = currentNum.ToString();
                var reversedNumArray = currentNumToStr.Reverse().ToArray();
                var reversedNum = new string(reversedNumArray);

                arr[i] = int.Parse(reversedNum);
            }
            Console.WriteLine(arr.Sum());
        }
    }
}
