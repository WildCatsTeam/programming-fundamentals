using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapePerSqM = double.Parse(Console.ReadLine());
            int wineLitersNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrape = area * grapePerSqM;
            double grapeForWine =  0.4 * totalGrape;
            double totalWineLiters = grapeForWine / 2.5;

            if (totalWineLiters >= wineLitersNeeded)
            {
                double wineLittersForWorkers = totalWineLiters - wineLitersNeeded;
                double winePerWorker = Math.Ceiling(wineLittersForWorkers / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {totalWineLiters} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLittersForWorkers)} liters left -> {winePerWorker} liters per person.");
            }
            else
            {
                double wineMissing = Math.Floor(wineLitersNeeded - totalWineLiters);
                Console.WriteLine($"It will be a tough winter! More {wineMissing} liters wine needed.");
            }
        }
    }
}
