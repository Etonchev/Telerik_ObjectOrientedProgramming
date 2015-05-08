using System;
using System.Collections.Generic;
using System.IO;

public struct Point3D
{
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
    public static Point3D PointZero()
    {
        return Point3D.start;
    }
    public override string ToString()
    {
        return String.Format("({0}, {1}, {2})", CoordinateX, CoordinateY, CoordinateZ);
    }
}

public static class Calcualte
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

public class Path
{
    public List<Point3D> PointsArray { get; set; }

    public Path()
    {
        PointsArray = new List<Point3D>();
    }
}

public static class PathStorage
{
    public static void SavePath(Path pathList)
    {
        StreamWriter writer = new StreamWriter(@"E:\point3DPaths.txt");
        using (writer)
        {
            foreach (var item in pathList.PointsArray)
            {
                writer.WriteLine("{0} {1} {2}", item.CoordinateX, item.CoordinateY, item.CoordinateZ);
            }
        }

        Console.WriteLine("Points saved in point3DPath.txt successfully !");
    }
    public static Path LoadPath(string fileLocation)
    {
        StreamReader reader = new StreamReader(fileLocation);
        Path path = new Path();
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] coordinate = line.Split(' ');
                Point3D point = new Point3D();
                point.CoordinateX = Convert.ToDouble(coordinate[0]);
                point.CoordinateY = Convert.ToDouble(coordinate[1]);
                point.CoordinateZ = Convert.ToDouble(coordinate[2]);
                path.PointsArray.Add(point);
                line = reader.ReadLine();
            }
        }

        return path;
    }
}

public class Test
{
    static void Main()
    {
        Point3D pointOne = new Point3D(3, 3, 3);
        Point3D pointTwo = new Point3D(2, 2, 2);
        Console.WriteLine(Calcualte.calculateDistance(pointOne, pointTwo).ToString());
        Console.WriteLine(Point3D.PointZero().ToString());
        Path pathArray = new Path();
        pathArray.PointsArray.Add(pointOne);
        pathArray.PointsArray.Add(pointTwo);
        PathStorage.SavePath(pathArray);
        Path loadedPath = new Path();
        loadedPath = PathStorage.LoadPath(@"E:\point3DPaths.txt");
        foreach (var item in loadedPath.PointsArray)
        {
            Console.WriteLine(item.ToString());
        }
    }
}