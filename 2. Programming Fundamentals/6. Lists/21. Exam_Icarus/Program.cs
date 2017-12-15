using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Exam_Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine()); //3
            string[] commands = Console.ReadLine().Split();
            int damage = 1;
            while (commands[0] != "Supernova")
            {
                int steps = int.Parse(commands[1]); // 2 // 2
                for (int i = 0; i < steps; i++)
                {
                    if (commands[0] == "left") // left //right
                    {
                        index--;
                        if (index < 0)
                        {
                            index = elements.Length - 1;
                            damage += 1;
                        }
                        elements[index] -= damage;
                    }
                    else if (commands[0] == "right")
                    {
                        index++;
                        if (index > elements.Length - 1)
                        {
                            index = 0;
                            damage += 1;
                        }
                        elements[index] -= damage;
                    }
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
