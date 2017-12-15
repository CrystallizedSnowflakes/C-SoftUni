using System;


namespace _11.OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double bigNumEven = double.MinValue;
            double minNumEven = double.MaxValue;
            double bigNumOdd = double.MinValue;
            double minNumOdd = double.MaxValue;
            double sumEven = 0;
            double sumOdd = 0;


            for (int i = 1; i <= n && n!=0; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    if (num > bigNumOdd)
                    {
                        bigNumOdd = num;
                    }
                    if ( num < minNumOdd)
                    {
                        minNumOdd = num;
                    }
                    sumOdd += num;
                }
                else if (i % 2 == 0)
                {
                    if (num > bigNumEven)
                    {
                        bigNumEven = num;
                    }
                    if (num < minNumEven)
                    {
                        minNumEven = num;
                    }
                    sumEven += num;
                }
            }
            if (n == 0) Console.WriteLine("OddSum={0}, \nOddMin=No, \nOddMax=No, \nEvenSum={1}, \nEvenMin=No, \nEvenMax=No", sumOdd, sumEven);
            else if (n == 1) Console.WriteLine("OddSum={0}, \nOddMin={1}, \nOddMax={2}, \nEvenSum={3}, \nEvenMin=No, \nEvenMax=No", sumOdd, minNumOdd, bigNumOdd, sumEven);
            else Console.WriteLine("OddSum={0}, \nOddMin={1}, \nOddMax={2}, \nEvenSum={3}, \nEvenMin={4}, \nEvenMax={5}", sumOdd, minNumOdd, bigNumOdd, sumEven, minNumEven, bigNumEven);
        }
    }
}
