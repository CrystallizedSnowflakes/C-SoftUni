using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"\d+([A-Za-z])";

            var result = Regex.Replace(text, pattern, @"$1$1");

            Console.WriteLine(result);
        }
    }
}
