using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            var input = Console.ReadLine();
            var pattern = @"(^|(?<=[!\?\.]\s))[^!\?\.]*\W" + keyword + @"\W[^!\?\.]*(?=[!\?\.])";

            MatchCollection sentences = Regex.Matches(input, pattern);

            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
