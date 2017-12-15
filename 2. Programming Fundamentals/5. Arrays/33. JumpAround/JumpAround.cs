using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // 2 3 5 7 5 4 8 4
            int index = 0;
            int sum = sequence[0];

            while (true)
            {
                int tempIndex = index; //0 -> 2 -> 7
                try
                {
                    index = tempIndex + sequence[tempIndex]; //0+2=2 -> 2+5=7 -> 7+4=11
                    sum += sequence[index]; //0+2=2 -> 2+5=7 -> 7+4=11
                }
                catch (Exception)
                {
                    try
                    {
                        index = tempIndex - sequence[tempIndex]; // 7-4=3
                        sum += sequence[index]; // 11+7=18
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
