using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _26.TakeSkipRope
{
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nums = @"[0-9]";

            var encodedText = input.ToCharArray().Select(x => x.ToString()).Where(x => !Regex.IsMatch(x, nums)).ToList();
            var numbers = input.ToCharArray().Select(x => x.ToString()).Where(x => Regex.IsMatch(x, nums)).ToList();
            var take = new List<int>();
            var skip = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0) take.Add(int.Parse(numbers[i]));
                else skip.Add(int.Parse(numbers[i]));
            }

            var currentSkip = 0;
            var result = "";
            for (int i = 0; i < take.Count; i++)
            {

                result += string.Join("", encodedText.Skip(currentSkip).Take(take[i]));
                currentSkip += take[i] + skip[i];
            }

            Console.WriteLine(result);
        }
    }
}
