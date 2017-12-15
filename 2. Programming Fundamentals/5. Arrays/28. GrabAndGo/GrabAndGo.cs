using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            long sum = 0;
            int index = 0;
            bool isPresent = false;

            for (int pos = 0; pos < sequence.Length; pos++)
            {
                if (sequence[pos] == number)
                {
                    index = pos; // the loop continue to the end and keep the last true pos :)
                    isPresent = true;
                }
            }

            if (!isPresent)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }

            for (int i = 0; i < index; i++)
            {
                sum += sequence[i];
            }
            Console.WriteLine(sum);
        }
    }
}
