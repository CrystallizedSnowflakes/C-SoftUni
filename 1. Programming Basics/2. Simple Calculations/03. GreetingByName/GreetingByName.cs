using System;


namespace _03.GreetingByName
{
    class GreetingByName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            /*Console.WriteLine("Hello, {0}!", name);*/
            Console.WriteLine($"Hello, {name}!");
            /*Console.WriteLine("Hello, " + name + "!");*/
        }
    }
}
