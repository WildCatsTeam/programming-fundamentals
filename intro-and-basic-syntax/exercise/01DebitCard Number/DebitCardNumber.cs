using System;
//Confirmed from Irena7509

namespace _01DebitCard_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            // read from console 4 lines with four number per line
            int firstNumbers = int.Parse(Console.ReadLine());
            int secendNumbers = int.Parse(Console.ReadLine());
            int thirdNumbers = int.Parse(Console.ReadLine());
            int fouthNumbers = int.Parse(Console.ReadLine());

            // Adding all number in 1 line and print
            Console.WriteLine("{0:D4} {1:d4} {2:D4} {3:D4} ", firstNumbers, secendNumbers, thirdNumbers, fouthNumbers);
        }
    }
}
