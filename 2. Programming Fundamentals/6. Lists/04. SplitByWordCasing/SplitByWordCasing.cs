using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] text = input.Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

            //List<string> sentence = Console.ReadLine().
            //    Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();

            List<string> lowerCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();

            foreach (var word in text)
            {
                bool isMixed = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!char.IsLetter(word[i]))
                    {
                        isMixed = true;
                        break;
                    }
                }
                if (word.ToUpper() == word && !isMixed) //!check -> check == false
                {
                    upperCaseWords.Add(word);
                }
                else if (word.ToLower() == word && !isMixed)
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
