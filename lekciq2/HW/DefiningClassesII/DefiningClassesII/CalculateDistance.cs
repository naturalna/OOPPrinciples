//Write a static class with a static method to calculate the distance between two points in the 3D space.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class CalculateDistance
{
    public static short Calc(Point3D firstPoint,Point3D secondPoint)
    {
        double CalcX = Math.Pow(firstPoint.Xcoor -secondPoint.Xcoor,2);
        double CalcY = Math.Pow(firstPoint.Ycoor - secondPoint.Ycoor,2);
        double CalcZ = Math.Pow(firstPoint.Zcoor - secondPoint.Zcoor,2);
        double result = Math.Sqrt(CalcX + CalcY + CalcZ);
        return (short)(result);
    }
}
