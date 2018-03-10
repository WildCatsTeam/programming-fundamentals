using System;

namespace _03MileТoKilometers
{
    class MileТoKilometers
    {
        static void Main(string[] args)
        {
		//we are reading from console Miles and Kilometers perMile
            double Miles = double.Parse(Console.ReadLine());
            double KmPerMile = 1.60934;
            double Kilometres = Miles * (double)KmPerMile;
			
			//giving a formula to calculate the result and getting the result
            Console.WriteLine("{0:F2}", Kilometres);
        }
    }
}
