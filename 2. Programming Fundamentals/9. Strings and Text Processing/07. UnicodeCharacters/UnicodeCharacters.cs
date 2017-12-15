using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();
            foreach (var c in text)
            {
                Console.Write($"\\u{((int)c).ToString("X4").ToLower()}");
            }
            Console.WriteLine();
        }
    }
}
