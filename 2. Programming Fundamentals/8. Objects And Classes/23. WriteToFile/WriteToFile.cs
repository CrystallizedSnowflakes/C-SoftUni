using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _23.WriteToFile
{
    class WriteToFile
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt");
            var chars = text.Where(c => ".,?!:".IndexOf(c) == -1).ToArray();

            File.WriteAllText("output1.txt", string.Join("", chars));
        }
    }
}
