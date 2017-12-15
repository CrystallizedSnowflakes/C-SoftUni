using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            //List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //bool check = true;
            //while (check)
            //{
            //    check = false;
            //    for (int pos = 0; pos < nums.Count; pos++) // till previous pos
            //    {
            //        if ((pos < nums.Count - 1) && (nums[pos] == nums[pos + 1]))
            //        {
            //            nums[pos] = nums[pos] + nums[pos + 1];
            //            nums.RemoveAt(pos + 1);
            //            check = true;
            //        }
            //    }
            //}
            //Console.WriteLine(string.Join(" ", nums));
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            List<double> nums = new List<double>();
            for (int pos = 0; pos < items.Length; pos++)
            {
                //int i = int.Parse(items[pos]);
                //nums.Add(i);
                nums.Add(int.Parse(items[pos]));
            }
            bool check = true;
            while (check)
            {
                check = false;
                for (int pos = 0; pos < nums.Count; pos++) // till previous pos
                {
                    if ((pos < nums.Count - 1) && (nums[pos] == nums[pos + 1]))
                    {
                        nums[pos] = nums[pos] + nums[pos + 1];
                        nums.RemoveAt(pos + 1);
                        check = true;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
// .Add("Berlin")
// .IndexOf("Berlin") return default = -1
// .Remove("Berlin")
// .RemoveAt(1)
// .Insert(1, "Berlin")
// .Min() -> List
// .Max() -> List
// .Sum(0 -> List
// .Average() -> List
// .Select(number => double.Parse(number)); -> List <=> .Select(double.Parse); //short version
// .Select((item) => Math.Round(Double.Parse(item));
// .OrderedBy(num => num);
// .OrderedBy(num => Math.Abs(num));
// string[] words = new string[] {"Sofia", "Varna", "Burgas", "Plovdiv"};
// IEnumerable<string> orderdByLastLetter = words.OrderedBy(w => w[w.length - 1]);
// .OrdedByDescending();
// .OrderBy(pair => pair.Value); // by first creteria
// .ThenBy(pair => pair.Key); // by second creteria
// var nums = new List<int>() { 10, 20, 30, 40, 50, 60 }
// .Take(3)
// .ToArray();
//  //nums = [10, 20, 30]
// var nums = new List<int>() { 10, 20, 30, 40, 50, 60}
// .Skip(3).Take(2)
// .ToArray();
// // nums = [40, 30]
// .Where(num => num % 2 == 0); -> Filters return Array
// .Count(x => x 5 2 == 1); -> връща бройка Filter
// .Distinct(); -> take the unique elements ако се повтаря не взима втори път
// .First(); -> Filter and take only the first element
// .Last();
// .Single();
// .Concat(); _> concat two arrays
// >Reverse();
// .Capacity
// .Sort()
// .Reverse() replace first with last
//  string input = "1 45 67 87 900 5"
// input.Split(new char[]{' ', ','}, StringSplitOption.RemoveEmptyEntries)
// string[] items = input.Split(' ');
// .Select(int.Parse)
// List<int> numbers = new List<int>{};
// for (String item : items) -> Java
// numbers.Add(int.Parse(item)) -> .Select(int.Parse)
// for (i = 0; i < numbers.Count; i++) -> .To List();
// sum += numbers[i];
// .split(RegEx) -> Java
//List<Integer> .size() -> Java
//List<int>  .Count -> C#
// string input = string.Join(" <= ", numbers);


