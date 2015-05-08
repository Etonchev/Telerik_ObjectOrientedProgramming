using System;

class MatrixClass<T>
{
    public T[,] Matrix { get; set; }
    public int Size { get; set; }

    public MatrixClass(int size)
    {
        Size = size;
        Matrix = new T[Size, Size];
    }

    public T this [int row, int column]
    {
        get
        {
            return Matrix[row, column];
        }
        set
        {
            Matrix[row, column] = value;
        }
    }
    public static MatrixClass<double> operator +(MatrixClass<double> m1, MatrixClass<double> m2)
    {
        if (m1.Size != m2.Size)
        {
            throw new Exception("Can't add matrix with different dimensions");
        }

        MatrixClass<double> result = new MatrixClass<double>(m1.Size);
        for (int row = 0; row < result.Size; row++)
        {
            for (int column = 0; column < result.Size; column++)
            {
                result[row, column] = m1.Matrix[row, column] + m2.Matrix[row, column];
            }
        }

        return result;
    }
    public static MatrixClass<double> operator -(MatrixClass<double> m1, MatrixClass<double> m2)
    {
        if (m1.Size != m2.Size)
        {
            throw new Exception("Can't subtract matrix with different dimensions");
        }

        MatrixClass<double> result = new MatrixClass<double>(m1.Size);
        for (int row = 0; row < result.Size; row++)
        {
            for (int column = 0; column < result.Size; column++)
            {
                result[row, column] = m1.Matrix[row, column] - m2.Matrix[row, column];
            }
        }

        return result;
    }
    public static MatrixClass<double> operator *(MatrixClass<double> m1, MatrixClass<double> m2)
    {
        if (m1.Size != m2.Size)
        {
            throw new Exception("Can't multiply matrix with different dimensions");
        }

        MatrixClass<double> result = new MatrixClass<double>(m1.Size);
        for (int row = 0; row < result.Size; row++)
        {
            for (int column = 0; column < result.Size; column++)
            {
                result[row, column] = m1.Matrix[row, column] * m2.Matrix[row, column];
            }
        }

        return result;
    }
}

public class MatrixTest
{
    public static void Main()
    {
        Console.WriteLine("Enter matrix size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        MatrixClass<double> firstMatrix = new MatrixClass<double>(size);
        for (int row = 0; row < firstMatrix.Size; row++)
        {
            for (int column = 0; column < firstMatrix.Size; column++)
            {
                Console.Write("Enter firstMatrix[{0},{1}] = ", row, column);
                firstMatrix[row, column] = Convert.ToInt32(Console.ReadLine());
            }
        }

        MatrixClass<double> secondMatrix = new MatrixClass<double>(size);
        for (int row = 0; row < firstMatrix.Size; row++)
        {
            for (int column = 0; column < secondMatrix.Size; column++)
            {
                Console.Write("Enter secondMatrix[{0},{1}] = ", row, column);
                secondMatrix[row, column] = Convert.ToInt32(Console.ReadLine());
            }
        }

        MatrixClass<double> result = firstMatrix + secondMatrix;
    }
}