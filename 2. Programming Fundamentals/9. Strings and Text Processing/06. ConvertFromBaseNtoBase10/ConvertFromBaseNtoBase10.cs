using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.ConvertFromBaseNtoBase10
{
    class ConvertFromBaseNtoBase10
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var @base = int.Parse(numbers[0]); 
            var num = numbers[1].Reverse().ToArray(); 

            var sum = new BigInteger();
            for (int power = 0; power < num.Length; power++)
            {
                var currentNum = int.Parse(num[power].ToString());
                sum += currentNum * BigInteger.Pow(@base, power);
            }
            Console.WriteLine(sum);
        }
    }
}
