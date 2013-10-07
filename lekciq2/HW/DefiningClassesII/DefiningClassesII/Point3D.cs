using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public struct Point3D
{
    public short Xcoor{ get; set;}
    public short Ycoor { get; set; }
    public short Zcoor { get; set; }
    public Point3D(short xcoord, short ycoord, short zcoord)
        : this()
    {
        this.Xcoor = xcoord;
        this.Ycoor = ycoord;
        this.Zcoor = zcoord;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.Xcoor + ", ");
        sb.Append(this.Ycoor + ", ");
        sb.Append(this.Zcoor);
        return sb.ToString();
    }
    //EX.2 
    //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    //Add a static property to return the point O.
    private static readonly Point3D pointO = new Point3D(0, 0, 0);
    public static Point3D PointO
    {
        get { return pointO; }
    }
}
