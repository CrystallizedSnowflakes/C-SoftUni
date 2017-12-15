using System;


namespace _17.Monay
{
    class Money
    {
        static void Main()
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double chineseCNY = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            int bitcoinIntoBNG = bitcoin * 1168;
            double yuanIntoUSD = chineseCNY * 0.15 * 1.76;
            double totalEUR = (bitcoinIntoBNG + yuanIntoUSD) / 1.95;
            double commissionInEUR = totalEUR * commission / 100;
            double result = totalEUR - commissionInEUR;

            Console.WriteLine(result);
        }
    }
}
