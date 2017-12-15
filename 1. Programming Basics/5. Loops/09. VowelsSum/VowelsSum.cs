using System;


namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            //Console.WriteLine(input.Length); //hello
            //Console.WriteLine(input[0]); //h
            //Console.WriteLine(input[5]); // out of range exception

            int sum = 0;

            for (int i = 0; i <= input.Length - 1; i++)
            {
                char currentChar = input[i];
                if (currentChar == 'a')
                {
                    sum++;
                }
                else if (currentChar == 'e')
                {
                    sum += 2;
                }
                else if (currentChar == 'i')
                {
                    sum += 3;
                }
                else if (currentChar == 'o')
                {
                    sum += 4;
                }
                else if (currentChar == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
