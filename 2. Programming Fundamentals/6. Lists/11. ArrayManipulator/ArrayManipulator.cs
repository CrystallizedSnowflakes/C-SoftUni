using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //[0.....1000]
            var line = Console.ReadLine();
            while (line != "print")
            {
                var tokens = line.Split();
                var command = tokens[0];
                if (command == "add")
                {
                    var index = int.Parse(tokens[1]); // convert string to int
                    var element = int.Parse(tokens[2]);
                    list.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    //var element = tokens.Skip(2).ToArray(); remove the first two elements
                    var elements = new List<int>();
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var currentItem = int.Parse(tokens[i]);
                        elements.Add(currentItem);
                    }
                    list.InsertRange(index, elements); //adding elements to index
                }
                else if (command == "contains")
                {
                    var element = int.Parse(tokens[1]);
                    var index = list.IndexOf(element); // return index of element or -1 by default
                    //var index = -1;
                    //if (list.Contains(element))
                    //{
                    //    for (int i = 0; i < list.Count; i++)
                    //    {
                    //        if (list[i] == element)
                    //        {
                    //            index = i;
                    //            break;
                    //        }
                    //    }
                    //}
                    Console.WriteLine(index);
                }
                else if (command == "remove")
                {
                    var index = int.Parse(tokens[1]);
                    list.RemoveAt(index);
                }
                else if (command == "shift")
                {
                    var count = int.Parse(tokens[1]) % list.Count; //% length return 0 -> loop don't need to circle
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (command == "sumPairs")
                {
                    var pairsSum = new List<int>();
                    for (int i = 0; i < list.Count; i += 2)
                    {
                        var currentElement = list[i];
                        var nextElement = 0;
                        if (i < list.Count - 1)
                        {
                            nextElement = list[i + 1];
                        }
                        var elementsSum = currentElement + nextElement;
                        pairsSum.Add(elementsSum);
                    }
                    list = pairsSum;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}
