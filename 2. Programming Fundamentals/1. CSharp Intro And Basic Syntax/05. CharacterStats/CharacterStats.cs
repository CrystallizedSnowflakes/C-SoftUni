using System;



class CharacterStats
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int currentHealth = int.Parse(Console.ReadLine());
        int maxHhealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', maxHhealth - currentHealth));
        Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));
    }
}

