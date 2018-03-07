using System;

namespace _01DebitCard_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());
            int FourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:D4} {1:d4} {2:D4} {3:D4} ", FirstNumber, SecondNumber, ThirdNumber, FourthNumber);
        }
    }
}
