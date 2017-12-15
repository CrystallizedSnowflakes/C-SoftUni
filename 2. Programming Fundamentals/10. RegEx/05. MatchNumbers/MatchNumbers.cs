using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            MatchCollection numbers = Regex.Matches(Console.ReadLine(), regex);

            foreach (Match num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
