using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); // 3
            var ladybugIndexes = Console.ReadLine()
                .Split() //split by space
                .Select(int.Parse) //convert string to int
                .Where(a => a >= 0 && a < fieldSize) //flter each 'a' to be > 0 && < FieldSize
                .ToArray(); // 0 1

            var ladybugs = new int[fieldSize]; //array with a fixed length | 0 0 0
            // fill the new array
            foreach (var ladybugIndex in ladybugIndexes) // for each index from ladybugsIndexes array put 1 = LADYBUG :)
            {
                ladybugs[ladybugIndex] = 1;
            }

            while (true)
            {
                var line = Console.ReadLine(); // reading the next lines
                if (line == "end")
                {
                    break;
                }
                // '0 right 1'
                var tokens = line.Split();
                var ladybugIndex = int.Parse(tokens[0]); // '0' index
                var direction = tokens[1]; // right
                var count = int.Parse(tokens[2]); // '1' nums to move 

                bool isInsideArray = ladybugIndex >= 00 && ladybugIndex < ladybugs.Length;
                if (!isInsideArray) // if the LADYBUG is outside the array
                {
                    continue; // do nothing | continue to read the next line
                }

                bool ladybugExists = ladybugs[ladybugIndex] == 1;
                if (!ladybugExists) // if there is NO LADYBUG on the index
                {
                    continue;
                }
                MoveLadybug(ladybugs, ladybugIndex, direction, count);
            }
            Console.WriteLine(string.Join(" ", ladybugs));
        }

        static void MoveLadybug(int[] ladybugs, int ladybugIndex, string direction, int count)
        {
            if (direction == "left")
            {
                count = -count; // make the count negative for 'left'
            }
            var nextIndex = ladybugIndex + count; // 0 + (-2) = -2

            ladybugs[ladybugIndex] = 0; // when LADYBUG FLY from the index clear it to 0

            var hasLeftArrayOrFindPlace = false;

            while (!hasLeftArrayOrFindPlace)
            {
                var hasLeftArray = nextIndex < 0 || nextIndex > ladybugs.Length - 1;
                if (hasLeftArray) // out of the array range
                {
                    hasLeftArrayOrFindPlace = true;
                    continue;
                }
                var ladybugAlreadyExistOnNextIndex = ladybugs[nextIndex] == 1; // has a LADYBUG on the index
                if (ladybugAlreadyExistOnNextIndex)
                {
                    nextIndex += count;
                    continue;
                }
                ladybugs[nextIndex] = 1; // put LADYBUG = 1 in the index cause is empty
                hasLeftArrayOrFindPlace = true;
            }
        }
    }
}
