using System;

namespace _01DebitCard_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            // read from console 4 lines with four number per line
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());
            int FourthNumber = int.Parse(Console.ReadLine());

            // Adding all number in 1 line and print
            Console.WriteLine("{0:D4} {1:d4} {2:D4} {3:D4} ", FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
        }
    }
}
