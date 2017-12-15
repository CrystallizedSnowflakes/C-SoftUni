using System;


namespace _07.SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n -1 )
                    /*{
                        if (j == 0 || j == n - 1)*/
                        {
                            Console.Write("*");
                        }
                        /*else
                        {
                            Console.Write(" ");
                        }
                    }*/
                    else
                    {
                        if(j == 0 || j == n -1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            /*for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine(new string('*', n));
                }
                else
                {
                    Console.WriteLine('*' + new string(' ', n - 2) + '*');
                }
            }*/
        }
    }
}
