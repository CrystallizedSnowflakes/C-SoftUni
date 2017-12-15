using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder yau = new StringBuilder();
        yau.Append('+'+string.Concat(Enumerable.Repeat('-', n-2))+'+').AppendLine();
        for (int i = 0; i < n-2; i++)
        {
            yau.Append('|' + string.Concat(Enumerable.Repeat('-', n-2)) + '|').AppendLine();
        }
        yau.Append('+' + string.Concat(Enumerable.Repeat('-', n - 2)) + '+').AppendLine();
        char[] kefi = new char[yau.Length];
        yau.CopyTo(0, kefi, 0, yau.Length);
        kefi.Select()
        //kefi.Where(x => "x ")
        Console.WriteLine(yau);
        //Console.WriteLine("+" + new string('-', n-2) + " +");
        //for (int i = 0; i < n-2; i++)
        //{
        //Console.WriteLine("|" + new string) + " |");
        //}
        //Console.WriteLine("+" + new string('-', n-2) + " +");
    }
}