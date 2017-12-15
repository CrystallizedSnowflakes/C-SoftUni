using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SMStyping
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string message = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string digits = Console.ReadLine();
            int mainDigit = int.Parse(digits[0].ToString()); //222 -> 2 first digit

            int offset = (mainDigit - 2) * 3;

            if (mainDigit == 8 || mainDigit == 9)
            {
                offset += 1;
            }
            int letterIndex = offset + digits.Length - 1; //digits.Lengt=222=3 find letter index a->0
            if (mainDigit == 0) //space
            {
                message += " ";
            }
            else
            {
                message += (char)(97 + letterIndex);
            }
        }
        Console.WriteLine(message);
    }
}

