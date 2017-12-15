using System;


namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int bigNum = int.MinValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > bigNum)
                {
                    bigNum = num;
                }
                sum += num;
            }
            if (bigNum == sum / 2)
            {
                Console.WriteLine("Yes Sum = {0}", bigNum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(bigNum - (sum - bigNum)));
            }
        }
    }
}
