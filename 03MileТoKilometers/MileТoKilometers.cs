using System;

namespace _03MileТoKilometers
{
    class MileТoKilometers
    {
        static void Main(string[] args)
        {
            double Miles = double.Parse(Console.ReadLine());
            double KmPerMile = 1.60934;
            double Kilometres = Miles * (double)KmPerMile;
            Console.WriteLine("{0:F2}", Kilometres);
        }
    }
}
