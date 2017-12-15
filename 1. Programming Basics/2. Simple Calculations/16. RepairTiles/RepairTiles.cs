using System;


namespace _16.RepairTiles
{
    class RepairTiles
    {
        static void Main()
        {
            double lengthPlayground = double.Parse(Console.ReadLine());
            double widthPlate = double.Parse(Console.ReadLine());
            double lengthPlate = double.Parse(Console.ReadLine());
            double widthBench = double.Parse(Console.ReadLine());
            double lengthBench = double.Parse(Console.ReadLine());

            double totalArea = Math.Pow(lengthPlayground, 2);
            double benchArea = widthBench * lengthBench;
            double coverArea = totalArea - benchArea;
            double plateArea = widthPlate * lengthPlate;

            double totalPlate = coverArea / plateArea;
            double totalTime = totalPlate * 0.2;

            Console.WriteLine(totalPlate);
            Console.WriteLine(totalTime);        
        }
    }
}
