//ex4. Create a class Path to hold a sequence of points in the 3D space. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class Path
{
    private List<Point3D> points = new List<Point3D>();
    public List<Point3D> Points
    {
        get { return this.points; }
        set { this.points = value; }
        // .Points[i] is posible
    }
    public Path()
    {
        // constructor
    }
    public void AddInPath(Point3D pointForAdd)
    {
        Points.Add(pointForAdd);
    }
}

