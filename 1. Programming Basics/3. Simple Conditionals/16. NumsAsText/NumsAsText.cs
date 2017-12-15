using System;


namespace _16.NumsAsText
{
    class NumsAsText
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (number < 10)
            {
                switch (number)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                }
            }
            else if (number < 20)
            {
                switch (number)
                {
                    case 10: Console.WriteLine("ten"); break;
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("thirteen"); break;
                    case 14: Console.WriteLine("fourteen"); break;
                    case 15: Console.WriteLine("fifteen"); break;
                    case 16: Console.WriteLine("sixteen"); break;
                    case 17: Console.WriteLine("seventeen"); break;
                    case 18: Console.WriteLine("eighteen"); break;
                    case 19: Console.WriteLine("nineteen"); break;
                }
            }
            else if (number < 100)
            {
                if (number / 10 == 2 )
                {
                    Console.Write("twenty");
                }
                if (number / 10 == 3)
                {
                    Console.Write("thirty");
                }
                if (number / 10 == 4)
                {
                    Console.Write("forty");
                }
                if (number / 10 == 5)
                {
                    Console.Write("fifty");
                }
                if (number / 10 == 6)
                {
                    Console.Write("sixty");
                }
                if (number / 10 == 7)
                {
                    Console.Write("seventy");
                }
                if (number / 10 == 8)
                {
                    Console.Write("eighty");
                }
                if (number / 10 == 9) // 21 / 10 = 2
                {
                    Console.Write("ninety");
                }
                int secondNumber = number % 10; // 21 % 10 = 1
                switch (secondNumber)
                {
                    case 1: Console.WriteLine(" one"); break;
                    case 2: Console.WriteLine(" two"); break;
                    case 3: Console.WriteLine(" three"); break;
                    case 4: Console.WriteLine(" four"); break;
                    case 5: Console.WriteLine(" five"); break;
                    case 6: Console.WriteLine(" six"); break;
                    case 7: Console.WriteLine(" seven"); break;
                    case 8: Console.WriteLine(" eight"); break;
                    case 9: Console.WriteLine(" nine"); break;
                }
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else 
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
