using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PhoneBookTwo
{
    class PhoneBookTwo
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            var phoneBook = new Dictionary<string, string>();

            while (arr[0] != "END")
            {
                var command = arr[0];
                var name = arr[1];

                if (command == "S")
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "A")
                {
                    var number = arr[2];
                    phoneBook[name] = number;
                }

                arr = Console.ReadLine().Split();
            }
        }
    }
}
