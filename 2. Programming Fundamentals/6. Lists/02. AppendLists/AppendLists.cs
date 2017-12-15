using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            //List<string> nums = Console.ReadLine().Split('|').ToList();
            //List<string> result = new List<string>();
            //for (int pos = nums.Count - 1; pos >= 0; pos--)
            //{
            //    var splited = nums[pos].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    result.Add(string.Join(" ", splited));
            //}
            //Console.WriteLine(string.Join(" ", result));
            string input = Console.ReadLine();
            string[] tokens = input.Split('|');
            List<string> result = new List<string>();
            for (int pos = tokens.Length - 1; pos >= 0; pos--)
            {
                string[] splittedArr = tokens[pos].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string joined = string.Join(" ", splittedArr);
                result.Add(joined);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
