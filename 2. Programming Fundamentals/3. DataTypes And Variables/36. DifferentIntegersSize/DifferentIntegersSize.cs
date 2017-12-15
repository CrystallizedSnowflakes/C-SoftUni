using System;
using System.Numerics;

class DifferentIntegersSize
{
    static void Main()
    {
        string digit = Console.ReadLine();

        try
        {
            long number = long.Parse(digit);
            if (number >= sbyte.MinValue && number < 0)
            {
                Console.WriteLine($"{number} can fit in: \n* sbyte \n* short \n* int \n* long");
            }
            else if (number >= 0 && number <= sbyte.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* sbyte \n* byte \n* short \n* ushort \n* int \n* uint \n* long");

            }
            else if (number > sbyte.MaxValue && number <= byte.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* byte \n* short \n* ushort \n* int \n* uint \n* long");
            }
            else if (number >= short.MinValue && number < sbyte.MinValue)
            {
                Console.WriteLine($"{number} can fit in: \n* short \n* int \n* long");
            }
            else if (number >= byte.MaxValue && number <= short.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* sbyte \n* byte \n* short \n* ushort \n* int \n* uint \n* long");
            }
            else if (number > short.MaxValue && number <= ushort.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* ushort \n* int \n* uint \n* long");
            }
            else if (number >= int.MinValue && number < short.MinValue)
            {
                Console.WriteLine($"{number} can fit in: \n* int \n* long");
            }
            else if (number > ushort.MaxValue && number <= int.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* int \n* uint \n* long");
            }
            else if (number > int.MaxValue && number <= uint.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* uint \n* long");
            }
            else if (number >= long.MinValue && number <int.MinValue)
            {
                Console.WriteLine($"{number} can fit in: \n* long");
            }
            else if (number > uint.MaxValue && number <= long.MaxValue)
            {
                Console.WriteLine($"{number} can fit in: \n* long");
            }
        }
        catch
        {
            Console.WriteLine($"{digit} can't fit in any type");
        }
    }
}

