using System;


namespace _13.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string typeOfFigure = Console.ReadLine();
            double result = 0;

            if (typeOfFigure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                result = Math.Pow(num, 2);
            }
            else if (typeOfFigure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b;
            }
            else if (typeOfFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(r, 2);
            }
            else if (typeOfFigure == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                result = (c * h) / 2;
            }
            Console.WriteLine(Math.Round(result, 3));
        }
    }
}
