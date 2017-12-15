using System;


namespace _19.CurrencyConverterNEW
{
    class CurrencyConverterNEW
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string inputCurrencyToUpper = inputCurrency.ToUpper();
            string outputCurrency = Console.ReadLine();
            string outputCurrencyToUpper = outputCurrency.ToUpper();

            double valueToBGN = 0;
            double result = 0;
            
            double oneUSD = 1.79549;
            double oneEUR = 1.95583;
            double oneGBP = 2.53405;

            if (inputCurrencyToUpper == "BGN")
            {
                valueToBGN = amount;
            }
            else if (inputCurrencyToUpper == "USD")
            {
                valueToBGN = amount * oneUSD;
            }
            else if (inputCurrencyToUpper == "EUR")
            {
                valueToBGN = amount * oneEUR;
            }
            else if (inputCurrencyToUpper == "GBP")
            {
                valueToBGN = amount * oneGBP;
            }


            if (outputCurrencyToUpper == "BGN")
            {
                result = valueToBGN;
            }
            else if (outputCurrencyToUpper == "USD")
            {
                result = valueToBGN / oneUSD;
            }
            else if (outputCurrencyToUpper == "EUR")
            {
                result = valueToBGN / oneEUR;
            }
            else if (outputCurrencyToUpper == "GBP")
            {
                result = valueToBGN / oneGBP;
            }
            Console.WriteLine("{0:f2}", result);
        }
    }
}
