using System;

namespace _01_Shapes
{
    class ClassTest
    {
        static void Main()
        {
            Shape[] shapes = new Shape[5];
            shapes[0] = new Rectangle(2, 4);
            shapes[1] = new Rectangle(3, 6);
            shapes[2] = new Triangle(5, 3);
            shapes[3] = new Triangle(4, 2);
            shapes[4] = new Square(2, 2);
            //shapes[5] = new Square(2, 3);

            for (int i = 0; i < shapes.Length - 1; i++ )
            {
                Console.WriteLine(shapes[i].CalculateSurface());
            }
        }
    }
}
