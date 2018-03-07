using System;

namespace _04BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            var Name = Console.ReadLine();
            var Volume = int.Parse(Console.ReadLine());
            var EnergyCont = int.Parse(Console.ReadLine());
            var SugarCont = int.Parse(Console.ReadLine());

            var Calories = Volume * EnergyCont / 100.0;
            var Sugar = Volume * SugarCont / 100.0;

            Console.WriteLine("{0}ml {1}:", Volume, Name);
            Console.WriteLine("{0}kcal, {1}g sugars", Calories, Sugar);

        }
    }
}
