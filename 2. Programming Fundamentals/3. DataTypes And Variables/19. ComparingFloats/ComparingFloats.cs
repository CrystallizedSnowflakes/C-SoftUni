using System;

class ComparingFloats
{
    static void Main()
    {
        double numOne = double.Parse(Console.ReadLine());
        double numTwo = double.Parse(Console.ReadLine());
        double eps = 0.000001;

        bool isEqual = (Math.Abs(numOne - numTwo)) < eps;

        Console.WriteLine(isEqual ? "True" : "False");
    }
}
