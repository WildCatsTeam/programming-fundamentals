using System;

namespace _02Rectangle_Area
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            // Here we receive the input data - width and height of the rectangle.
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());

            // Calculate the result (area).
            double Result = Width * Height;

            // Printing the result at the console.
            Console.WriteLine("{0:F2} ", Result);
        }
    }
}
