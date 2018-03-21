//CONFIRMED from rymen96
using System;

namespace _03MileТoKilometers
{
    class MileТoKilometers
    {
        static void Main(string[] args)
        {
		//we are reading from console Miles and Kilometers perMile
            double miles = double.Parse(Console.ReadLine());
<<<<<<< HEAD
            double kmPerMile = 1.60934;
            double Kilometres = miles * (double)kmPerMile;
			
=======
            double milesPerKm = 1.60934;
            double total = miles * (double)kmPerMile;
>>>>>>> 411e095020d3c43cefbff22a0f69dd6eb71be456
			//giving a formula to calculate the result and getting the result
            Console.WriteLine("{0:F2}", total);
        }
    }
}
