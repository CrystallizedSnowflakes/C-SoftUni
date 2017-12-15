using System;


namespace _07.LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            /*for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            for (int j = 1; j <= n; j++)
            {
                int num2 = int.Parse(Console.ReadLine());
                rightSum += num2;
            }*/

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff= "+ Math.Abs(leftSum-rightSum));
            }
        }
    }
}
