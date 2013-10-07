//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
//Implement the ToString() to enable printing a 3D point.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct PointTHreeD
{
    static void Main()
    {
        Console.WriteLine("------------------------------Ex.1------------------------------");
        Point3D point = new Point3D(10, 20, 30);
        Console.Write("Override ToString(): ");
        Console.WriteLine(point.ToString());
        //ex2
        Console.WriteLine("------------------------------Ex.2------------------------------");
        Console.WriteLine(Point3D.PointO);
        //ex3
        Console.WriteLine("------------------------------Ex.3------------------------------");
        Console.Write("Distance : ");
        Point3D point1 = new Point3D(0,0,0);
        Point3D point2 = new Point3D(0,3,4);
        Console.WriteLine(CalculateDistance.Calc(point1,point2));
        Console.WriteLine("------------------------------Ex.4------------------------------");
        Path path = new Path();
        path.AddInPath(point1);
        path.AddInPath(point2);
        Console.WriteLine(path.Points[0]);
        PathStorage.SaveData(path);
        Path loadedPath = new Path();
        loadedPath = PathStorage.LoadData();
        Console.WriteLine("The loaded path has points :");
        foreach (var item in loadedPath.Points)
        {
            Console.WriteLine(item);
        }
    }
}
