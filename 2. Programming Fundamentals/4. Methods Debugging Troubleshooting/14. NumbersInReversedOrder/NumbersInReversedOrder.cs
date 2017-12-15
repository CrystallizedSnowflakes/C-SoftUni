using System;
using System.Linq;

class NumbersInReversedOrder
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        var reversedNum = GetREvercedDecimalNum(number);
        Console.WriteLine(reversedNum);
    }

    static decimal GetREvercedDecimalNum(decimal num)
    {
        //string numToString = number.ToString();
        //string result = string.Empty;
        //for (int i = numToString.Length - 1; i >= 0; i--) //from last to first index
        //{
        //    result += numToString[i];
        //}
        //return decimal.Parse(result);

        string numToString = new string(num.ToString().Reverse().ToArray());
        return decimal.Parse(numToString);
    }
}

