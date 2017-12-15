using System;


namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            int maxnumber = int.MinValue;

            for (int i = 0; i < lenght; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > maxnumber)
                {
                    maxnumber = num;
                }
            }
            Console.WriteLine(maxnumber);
        }
    }
}
