using System;

namespace _01_Shapes
{
    class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
            if (width != height)
            {
                throw new Exception("Squares must have the same width and height !");
            }
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
