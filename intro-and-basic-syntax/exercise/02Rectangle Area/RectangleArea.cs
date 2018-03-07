using System;

namespace _02Rectangle_Area
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());

            double Result = Width * Height;
            Console.WriteLine("{0:F2} ", Result);
        }
    }
}
