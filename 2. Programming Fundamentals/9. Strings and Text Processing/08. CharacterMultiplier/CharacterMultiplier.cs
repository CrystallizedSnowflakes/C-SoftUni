using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().ToArray();

            var result = CharMultiplier(strings[0], strings[1]);

            Console.WriteLine(result);
        }

        private static int CharMultiplier(string firstString, string secondString)
        {
            var result = 0;
            var shorterLength = Math.Min(firstString.Length, secondString.Length);
            var longerLength = Math.Max(firstString.Length, secondString.Length);

            for (int i = 0; i < shorterLength; i++)
            {
                result += firstString[i] * secondString[i];
            }

            for (int i = shorterLength; i < longerLength; i++)
            {
                try
                {
                    result += firstString[i];
                }
                catch
                {
                    result += secondString[i];
                }
            }
            return result;
        }
    }
}
