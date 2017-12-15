using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToList();

            var counter = new Dictionary<string, int>();

            foreach (var word in words)             //foreach (var word in words)
            {                                       //{
                if (counter.ContainsKey(word))      //    counter[word] = 0; 
                {                                   //}
                    counter[word]++;                //foreach (var word in words)
                }                                   //{
                else                                //    counter[word]++;
                {                                   //}
                    counter[word] = 1;
                }
            }

            var result = new List<string>();

            foreach (var pairs in counter)
            {
                if (pairs.Value % 2 == 1)
                {
                    result.Add(pairs.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
