using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length); //To generate a random number in range use rnd.Next(minValue, maxValue).
                //Note that by definition minValue is inclusive, but maxValue is exclusive.
                //if (pos1 != pos2)
                //{
                    string tempo = words[pos1];
                    words[pos1] = words[pos2];
                    words[pos2] = tempo;
                //}
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
