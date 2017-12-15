using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine();
            var pattern = Console.ReadLine();
            var shake = true;

            while (shake)
            {
                var tokens = sequence.Split(new string[] { pattern }, StringSplitOptions.None).ToList().Count;

                if (tokens < 3) break;

                Console.WriteLine("Shaked it.");

                sequence = sequence.Remove(sequence.IndexOf(pattern), pattern.Length);
                sequence = sequence.Remove(sequence.LastIndexOf(pattern), pattern.Length);

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(sequence);
        }
    }
}
