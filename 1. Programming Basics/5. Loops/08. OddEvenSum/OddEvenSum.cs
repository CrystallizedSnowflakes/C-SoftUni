using System;


namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n  ; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else if (i % 2 == 1)
                {
                    oddSum += num;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes Sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No Diff= " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}

// num = num > 7 ? num += 5 : num +=2;
//     if num > 7 do +=5 else +=2;
// num = str == "zdrasti" ? :
