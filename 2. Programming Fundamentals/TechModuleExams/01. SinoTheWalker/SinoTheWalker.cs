using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            int[] timeToGoHome = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            int steps = int.Parse(Console.ReadLine());
            int secondsPerStep = int.Parse(Console.ReadLine());
            long timeInSeconds = timeToGoHome[0] * 3600 + timeToGoHome[1] * 60 + timeToGoHome[2];
            long secondsToHome = (long)steps * secondsPerStep;
            long totalSeconds = timeInSeconds + secondsToHome;

            long minutes = totalSeconds / 60;
            long seconds = totalSeconds % 60;
            long hours = 0;
            if (minutes >= 60)
            {
                hours = minutes / 60;
                minutes = minutes % 60;
            }
            if (hours >= 24)
            {
                hours = hours % 24;
            }
            Console.WriteLine($"Time Arrival: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
