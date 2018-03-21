using System;
//confirmed Irena 7509
namespace _04BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            // We read from console Name, Volume, EnergyCount and SugarCount
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyCont = int.Parse(Console.ReadLine());
            var sugarCont = int.Parse(Console.ReadLine());
            // Here we calculate Calories per 100gr
            var calories = volume * energyCont / 100.0;
            // Here calculate Sugar per 100gr
            var sugar = volume * sugarCont / 100.0;
            //Write results
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", calories, sugar);

        }
    }
}
