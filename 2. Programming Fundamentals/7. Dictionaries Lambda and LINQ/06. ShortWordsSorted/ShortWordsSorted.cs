using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] comparer = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = Console.ReadLine().ToLower().Split(comparer).Distinct().Where(x => x.Length < 5 && x.Length > 0).OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
