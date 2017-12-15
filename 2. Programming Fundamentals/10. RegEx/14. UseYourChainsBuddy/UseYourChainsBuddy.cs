using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.UseYourChainsBuddy
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, @"<p>(.*?)</p>")
                .Cast<Match>()
                .Select(x => Regex.Replace(x.Groups[1].Value, @"[^a-z0-9]+", " "))
                .Select(x => Regex.Replace(x, @"([a-z])", m => ((char)(m.Value.ToCharArray().Select(c => { if (c <= 'm') return (char)(c + 13); return (char)(c - 13); }).Last())).ToString()))
                .ToList();

            Console.WriteLine(string.Join("", matches));
        }
    }
}
