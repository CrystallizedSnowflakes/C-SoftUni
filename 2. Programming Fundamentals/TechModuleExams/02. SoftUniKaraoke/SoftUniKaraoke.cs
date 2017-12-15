using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            // Read input data
            string[] allSingers = Regex.Split(Console.ReadLine(), @"\s*, \s*"); // s* sequence of spaces, following by ',' following by sequence of spaces
            //var singers = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray(); // split by ',' - and remove speces around ','
            string[] allSongs = Regex.Split(Console.ReadLine(), @"\s*, \s*");
            //var songs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToArray(); 
            
            // Collect awards for each singer
            var awardsBySinger = new Dictionary<string, List<string>>();

            foreach (var s in allSingers)
            {
                awardsBySinger[s] = new List<string>(); // empty list for the awards
            }
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "dawn")
                {
                    break;
                }
                var tokens = Regex.Split(command, @"\s*, \s*");
                var singer = tokens[0];
                var song = tokens[1];
                var award = tokens[2];
                if (allSingers.Contains(singer) && allSongs.Contains(song))
                {
                    awardsBySinger[singer].Add(award);
                }
            }

            // Print the results
            var result = awardsBySinger.Select(item => new // anonymous class
            {
                singerName = item.Key,
                awards = item.Value.Distinct().OrderBy(aw => aw), // remove repeating things
                awardsCount = item.Value.Distinct().Count() // nums of awards
            })
            .OrderByDescending(s => s.awardsCount) //sorting each singer by nums of awards
            .ThenBy(s => s.singerName) // sorting by name
            .Where(s => s.awardsCount > 0) // remove singers with no awards|ex. awards = 0 | takes singers with more than 0 awards
            .ToArray();

            foreach (var s in result)
            {
                Console.WriteLine($"{s.singerName}: {s.awardsCount} awards");
                foreach (var aw in s.awards)
                {
                    Console.WriteLine($"--{aw}");
                }
            }
            if (result.Length == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
