using System;


namespace _11.USDtoBGN
{
    class USDtoBGN
    {
        static void Main()
        {
            double currencyUSD = double.Parse(Console.ReadLine());

            double currencyBGN = currencyUSD * 1.79549;

            Console.WriteLine("{0:f2}", currencyBGN);
        }
    }
}
