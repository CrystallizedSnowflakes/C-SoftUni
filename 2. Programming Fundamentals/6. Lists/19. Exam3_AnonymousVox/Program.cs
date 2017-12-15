using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _19.Exam3_AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            //string encodedText = Console.ReadLine();
            //string placeholders = Console.ReadLine();

            string regex = @"([a-zA-Z)]+)(\S+)\1";

            MatchCollection validNames = Regex.Matches(Console.ReadLine(), regex);

            foreach (Match name in validNames)
            {
                Console.Write(name + " ");
            }
        }
    }
}
