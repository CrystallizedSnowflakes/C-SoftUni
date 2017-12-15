using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Exam2_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();//new List<string> { "Ivo", "Johny", "Tony", "Bony", "Mony" }; // = 5
            List<string> commands = Console.ReadLine().Split(' ').ToList(); //new List<string> { "merge", "1", "3" };// merge 0 3  merge 3 4  merge 0 3

            while (commands[0] != "3:1")
            {
                string singleCommand = commands[0]; // merge
                int startIndex = int.Parse(commands[1]); // 0 
                int endIndexOrPartitions = int.Parse(commands[2]); // 3 
                if (startIndex > words.Count)
                {
                    commands = Console.ReadLine().Split(' ').ToList();
                    continue;
                }
                if (startIndex < 0)
                    startIndex = 0;
                if (endIndexOrPartitions > words.Count)
                    endIndexOrPartitions = words.Count - 1;

                if (singleCommand.Equals("merge")) //true
                {
                    List<string> mergedLetters = new List<string>();
                    mergedLetters = words.GetRange(startIndex, endIndexOrPartitions - startIndex + 1); // Ivo 
                    words.RemoveRange(startIndex, endIndexOrPartitions - startIndex + 1); // start index, count
                    string stringWords = string.Join("", mergedLetters);
                    words.Insert(startIndex, stringWords); // at which index, what we insert
                }
                else 
                {
                    string wordToBeDevided = words[startIndex]; //qrstuvwx yz
                    words.RemoveRange(startIndex, 1);
                    var fragmentLength = wordToBeDevided.Length / endIndexOrPartitions; // 10 / 5 = 2
                    List<string> pieces = new List<string>();
                    for (int i = 0; i < endIndexOrPartitions - 1; i++) // a, b, cd
                    {
                        string piece = wordToBeDevided.Substring(0, fragmentLength); // a // b
                        wordToBeDevided = wordToBeDevided.Substring(fragmentLength); // bcd // cd
                        pieces.Add(piece); // a, b , cd
                    }
                    pieces.Add(wordToBeDevided);
                    words.InsertRange(startIndex, pieces); // at which index, what we insert
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
