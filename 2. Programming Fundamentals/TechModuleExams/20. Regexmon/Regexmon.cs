using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20.Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var bojomonPattern = @"[a-zA-Z]+\-[a-zA-Z]+";
            var didimonPattern = @"[^a-zA-Z-]+";
            var nextText = text;
            var lastIndex = 0;

            while(lastIndex != nextText.Length - 1)
            {
                var didimonMatch = Regex.Match(nextText, didimonPattern);
                if (didimonMatch.Success)
                {
                    var textDidi = didimonMatch.Value; // ^^^^
                    Console.WriteLine(textDidi);
                    var indexDidi = text.IndexOf(didimonMatch.Value); // 0
                    lastIndex = textDidi.Length - 1;
                    nextText = text.Remove(0, indexDidi + textDidi.Length);
                    text = nextText;
                }
                else
                {
                    break;
                }

                var bojomonMatch = Regex.Match(nextText, bojomonPattern);
                if (bojomonMatch.Success)
                {
                    var textBojo = bojomonMatch.Value;
                    Console.WriteLine(textBojo);
                    var indexBojo = nextText.IndexOf(bojomonMatch.Value);
                    lastIndex = textBojo.Length - 1;
                    nextText = nextText.Remove(0, indexBojo + textBojo.Length);
                    text = nextText;

                    //text = text.Substring(indexDidi, textDidi.Length);
                }
                else
                {
                    break;
                }
            } 
        }
    }
}
