using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder yea = new StringBuilder();
        for (int i = 0; i < n * n; i++)
        {
            yea.Append("* ");
            if ((i + 1) % n == 0)
            {
                yea.Remove(yea.Length - 1, 1).AppendLine();
            }
        }
        Console.Write(yea);
    }
}