using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Exam4_AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] comparer = { '-', '>', '|', ' ' };
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            var anonymous = new Dictionary<string, Dictionary<string, int>>();
            var cache = new Dictionary<string, int>();

            while (input[0] != "thetinggoesskrra")
            {
                if (input.Length == 1)
                {
                    var givenDataSet = input[0];
                    if (!anonymous.ContainsKey(givenDataSet))
                    {
                        anonymous.Add(givenDataSet, new Dictionary<string, int>());
                    }
                }
                else
                {
                    var dataKey = input[0];
                    int dataSize = int.Parse(input[1]);
                    var dataSet = input[3];
                    if (anonymous.ContainsKey(dataSet))
                    {
                        anonymous[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        cache.Add(dataKey, dataSize);
                    }
                    if (cache.ContainsValue(dataSize) && input[0] == dataSet)
                    {
                        anonymous.Add(dataSet, new Dictionary<string, int>() { { dataKey, dataSize } });
                    }
                }
                input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var pair in anonymous)
            {
                Console.WriteLine($"Data Set: {pair.Key}, Total Size: {pair.Value}");
                Console.WriteLine($"$.{pair.Key}");
            }
        }
    }
}
