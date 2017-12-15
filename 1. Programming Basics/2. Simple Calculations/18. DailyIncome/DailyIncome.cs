using System;


namespace _18.DailyIncome
{
    class DailyIncome
    {
        static void Main()
        {
            int daysPerMonth = int.Parse(Console.ReadLine());
            double moneyPerDay = double.Parse(Console.ReadLine());
            double rateUSD = double.Parse(Console.ReadLine());

            double monthSelary = daysPerMonth * moneyPerDay;
            double bonus = monthSelary * 2.5;
            double moneyPerYear = (monthSelary * 12) + bonus;
            double tax = moneyPerYear * 0.25;
            double yearIncome = (moneyPerYear - tax) * rateUSD;
            double incomePerDayBGN = yearIncome / 365;

            Console.WriteLine("{0:f2}", incomePerDayBGN);
        }
    }
}
