using System;

public struct Point3D
{
    private double coordinateX;
    private double coordinateY;
    private double coordinateZ;
    private static readonly Point3D start = new Point3D(0, 0, 0);

    public double CoordinateX
    { get; set; }
    public double CoordinateY
    { get; set; }
    public double CoordinateZ
    { get; set; }
    public Point3D(double x, double y, double z) : this()
    {
        this.CoordinateX = x;
        this.CoordinateY = y;
        this.CoordinateZ = z;
    }
    public override string ToString()
    {
        return String.Format("{0}, {1}, {2}", CoordinateX, CoordinateY, CoordinateZ);
    }
}

static class Calcualte
{
    public static Point3D calculateDistance (Point3D first, Point3D second)
    {
        Point3D result = new Point3D();
        result.CoordinateX = first.CoordinateX - second.CoordinateX;
        result.CoordinateY = first.CoordinateY - second.CoordinateY;
        result.CoordinateZ = first.CoordinateZ - second.CoordinateZ;
        return result;
    }
}

public class Test
{
    static void Main()
    {
        Point3D pointOne = new Point3D(3, 3, 3);
        Point3D pointTwo = new Point3D(2, 2, 2);
        Console.WriteLine(Calcualte.calculateDistance(pointOne, pointTwo).ToString());
    }
}