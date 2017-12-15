﻿using System;



class Megapixels
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double megapixels = Math.Round(width * height / 1000000, 1);

        Console.WriteLine($"{width}x{height} => {megapixels}MP"); 
    }
}

