using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().ToArray();

            Console.WriteLine(AreExchangeable(strings[0], strings[1]) ? "true" : "false");
        }

        private static bool AreExchangeable(string firstString, string secondString)
        {
            var uniqueFirstString = firstString.ToCharArray().Distinct().ToList().Count;
            var uniqueSecondString = secondString.ToCharArray().Distinct().ToList().Count;

            return uniqueFirstString == uniqueSecondString;
        }
    }
}
