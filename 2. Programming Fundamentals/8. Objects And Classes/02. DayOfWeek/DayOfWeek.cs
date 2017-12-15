using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture); //18-4-2016
            Console.WriteLine($"{date.DayOfWeek}"); //Monday
        }
    }
}
