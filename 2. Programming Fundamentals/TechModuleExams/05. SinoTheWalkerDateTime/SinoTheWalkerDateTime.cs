﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SinoTheWalkerDateTime
{
    class SinoTheWalkerDateTime
    {
        static void Main(string[] args)
        {
            var departTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secPerStep = int.Parse(Console.ReadLine());
            double totalseconds = 1.0 * steps * secPerStep;
            totalseconds %= (3600 * 24);
            Console.WriteLine($"Time Arrival: {departTime.AddSeconds(totalseconds):HH:mm:ss}");
        }
    }
}
