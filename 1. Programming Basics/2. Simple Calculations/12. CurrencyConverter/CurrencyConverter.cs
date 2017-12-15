using System;


namespace _12.CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string inputCurrencyToUpper = inputCurrency.ToUpper();
            string outputCurrency = Console.ReadLine();
            string outputCurrencyToUpper = outputCurrency.ToUpper();

            if (inputCurrencyToUpper == "BGN" && outputCurrencyToUpper == "USD")
            {
                double result = amount / 1.79549;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "BGN" && outputCurrencyToUpper == "EUR")
            {
                double result = amount / 1.95583;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "BGN" && outputCurrencyToUpper == "GBP")
            {
                double result = amount / 2.53405;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "USD" && outputCurrencyToUpper == "BGN")
            {
                double result = amount * 1.79549;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "USD" && outputCurrencyToUpper == "EUR")
            {
                double result = amount * 1.79549 / 1.95583;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "USD" && outputCurrencyToUpper == "GBP")
            {
                double result = amount * 1.79549 / 2.53405;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "EUR" && outputCurrencyToUpper == "BGN")
            {
                double result = amount * 1.95583;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "EUR" && outputCurrencyToUpper == "USD")
            {
                double result = amount * 1.95583 / 1.79549;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "EUR" && outputCurrencyToUpper == "GBP")
            {
                double result = amount * 1.95583 / 2.53405;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "GBP" && outputCurrencyToUpper == "BGN")
            {
                double result = amount * 2.53405;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "GBP" && outputCurrencyToUpper == "USD")
            {
                double result = amount * 2.53405 / 1.79549;
                Console.WriteLine("{0:f2}", result);
            }
            else if (inputCurrencyToUpper == "GBP" && outputCurrencyToUpper == "EUR")
            {
                double result = amount * 2.53405 / 1.95583;
                Console.WriteLine("{0:f2}", result);
            }
        }
    }
}
