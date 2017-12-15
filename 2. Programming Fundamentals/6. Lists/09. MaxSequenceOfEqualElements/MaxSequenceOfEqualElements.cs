 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); //[0.....1000]
            var maxSequenceOfEqualElements = FindMaxSequenceOfEqualElements(inputArr);
            Console.WriteLine(string.Join(" ", maxSequenceOfEqualElements));
        }

        static int[] FindMaxSequenceOfEqualElements(int[] arr)
        {
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();
            currentSequence.Add(arr[0]); //set first element
            for (int pos = 1; pos < arr.Length; pos++)
            {
                var currentNum = arr[pos];
                var searchNum = currentSequence[0];
                if (currentNum == searchNum)    
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence); //copy currentSequence to longestSequence
                    }
                    currentSequence.Clear(); // = new List<int>(); start new collection from currentNum
                    currentSequence.Add(currentNum);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
            return longestSequence.ToArray();
        }
    }
}
