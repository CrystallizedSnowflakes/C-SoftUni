using System;


namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string yearType = Console.ReadLine();
            double holidyas = double.Parse(Console.ReadLine());
            double homeWeekend = double.Parse(Console.ReadLine());

            double sofiaWeekend = 48 - homeWeekend;
            double satudayGames = sofiaWeekend * 3 / 4;
            double holidaysGames = holidyas * 2 / 3;

            double totalGames = homeWeekend + satudayGames + holidaysGames;

            if (yearType == "normal")
            {
                Console.WriteLine(Math.Floor(totalGames));
            }
            else if (yearType == "leap")
            {
                double addGames = totalGames * 0.15;
                double result = totalGames + addGames;
                Console.WriteLine(Math.Floor(result));
            }
        }
    }
}
