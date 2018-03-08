using System;

namespace _04BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            // We read from console Name, Volume, EnergyCount and SugarCount
            var Name = Console.ReadLine();
            var Volume = int.Parse(Console.ReadLine());
            var EnergyCont = int.Parse(Console.ReadLine());
            var SugarCont = int.Parse(Console.ReadLine());
            // Here we calculate Calories per 100gr
            var Calories = Volume * EnergyCont / 100.0;
            // Here calculate Sugar per 100gr
            var Sugar = Volume * SugarCont / 100.0;
            //Write results
            Console.WriteLine("{0}ml {1}:", Volume, Name);
            Console.WriteLine("{0}kcal, {1}g sugars", Calories, Sugar);

        }
    }
}
