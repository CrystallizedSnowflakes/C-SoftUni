using System;



class BeverageLabels
{
    static void Main()
    {
        string name = Console.ReadLine();
        int volume = int.Parse(Console.ReadLine());
        int energyPerHundredml = int.Parse(Console.ReadLine());
        int sugarPerHundredml = int.Parse(Console.ReadLine());

        double energyContent = volume * energyPerHundredml * 0.01;
        double sugarContent = volume * sugarPerHundredml * 0.01;

        Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, energyContent, sugarContent);
    }
}

