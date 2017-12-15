using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ByteFlip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine()
               .Split()
               .Where(x => x.Length == 2) //takes elements with lenght 2
               .Select(x => string.Join("", x.ToCharArray().Reverse().ToList())) //reverse the digits in every number and put them in a list
               .Reverse() // reverse the list
               .Select(x => Convert.ToInt32(x, 16)) //convert every element from hexadecimal numbers 
               .Select(x => (char)x) //to characters from the ASCII table
               .ToList()
               ;


            Console.WriteLine(string.Join("", sequence));
        }
    }
}
