//CONFIRMED from rymen96
using System;

namespace _03MileТoKilometers
{
    class MileТoKilometers
    {
        static void Main(string[] args)
        {
		//we are reading from console Miles and Kilometers perMile
            double Miles = double.Parse(Console.ReadLine());
<<<<<<< HEAD
            double KmPerMile = 1.60934;
            double Kilometres = Miles * (double)KmPerMile;
			
=======
            double MilesPerKm = 1.60934;
            double total = Miles * (double)KmPerMile;
>>>>>>> 411e095020d3c43cefbff22a0f69dd6eb71be456
			//giving a formula to calculate the result and getting the result
            Console.WriteLine("{0:F2}", total);
        }
    }
}
