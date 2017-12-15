using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int averageLapsPerRunner = int.Parse(Console.ReadLine());
            int lengthOfTheLap = int.Parse(Console.ReadLine());
            int capacityOfTheTrack = int.Parse(Console.ReadLine());
            double donatedMoneyPerKm = double.Parse(Console.ReadLine());

            long maxRunners = (long)capacityOfTheTrack * days;

            if (runners > maxRunners)
            {
                runners = maxRunners;
            }
            long totalMeters = runners * averageLapsPerRunner * lengthOfTheLap;
            long totalKilometers = totalMeters / 1000;

            double raisedMoney = totalKilometers * donatedMoneyPerKm;
            Console.WriteLine($"Money raised: {raisedMoney:F2}");
        }
    }
}
