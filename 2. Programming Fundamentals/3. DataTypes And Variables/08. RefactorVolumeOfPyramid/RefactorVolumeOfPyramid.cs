using System;

class RefactorVolumeOfPyramid
{
    static void Main()
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double volumeOfPyramid = (length * width * height / 3);

        Console.WriteLine("Length: Width: Height: Pyramid Volume: {0:F2}", volumeOfPyramid);
    }
}

