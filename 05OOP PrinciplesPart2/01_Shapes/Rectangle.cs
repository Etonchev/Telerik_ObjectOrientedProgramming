using System;

namespace _01_Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
