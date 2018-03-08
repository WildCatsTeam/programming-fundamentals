using System;

namespace _05CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealt = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthAsText = new string('|', currentHealth);
            string healthMissing = new string('.', maxHealt - currentHealth);

            string energyAsText = new string('|', currEnergy);
            string energyMissing = new string('.', maxEnergy - currEnergy);
            Console.WriteLine(@"Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", healthAsText, healthMissing);
            Console.WriteLine("Energy: |{0}{1}|", energyAsText, energyMissing);
        }
    }
}
