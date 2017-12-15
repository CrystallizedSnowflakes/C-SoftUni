using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Exam_HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            List<long> bees = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            List<int> hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            long hornetPower = hornets.Sum();
            int i = 0;
            long lastBeehive = bees.Last(); // 30
            //bool lastBattle = false;
            do
            {
                //lastBattle = bees.Count >= 1 ? false : true;
                if (hornetPower >= bees[i])
                {
                    if (hornetPower == bees[i])
                    {
                        hornets.Remove(hornets[0]);
                    }
                    bees.Remove(bees[i]);
                    i--;
                }
                else
                {
                    bees[i] -= hornetPower;
                    hornets.Remove(hornets[0]);
                }
                hornetPower = hornets.Sum();
                i++;
            }
            while (bees.Count != 0 && hornets.Count > 0 && lastBeehive == bees.Last()/*lastBattle*/);
            if (bees.Count > 0)
            {
                Console.WriteLine(string.Join(" ", bees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
