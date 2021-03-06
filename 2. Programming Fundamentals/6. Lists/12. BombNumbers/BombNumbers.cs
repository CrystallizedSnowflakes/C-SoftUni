﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //[0.....1000]
            var bombTokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var bombNum = bombTokens[0];
            var bombStrength = bombTokens[1];

            for (int i = 0; i < list.Count; i++)
            {
                var currentNum = list[i];
                if (currentNum == bombNum)
                {
                    var leftIndex = Math.Max(i - bombStrength, 0); // prevent out of range /bigger than the arr.Length
                    var rightIndex = Math.Min(i + bombStrength, list.Count - 1);

                    var removeCount = rightIndex - leftIndex + 1;
                    list.RemoveRange(leftIndex, removeCount);
                    i = -1;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
