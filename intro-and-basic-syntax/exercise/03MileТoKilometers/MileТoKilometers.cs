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
            double MilesPerKm = 1.60934;
            double total = Miles * (double)KmPerMile;
			//giving a formula to calculate the result and getting the result
            Console.WriteLine("{0:F2}", total);
        }
    }
}
