using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Circle : Shape
{
    public Circle(float radius)
        : base(radius,radius)
    {
    }
    public override float CalculateSurface()
    {
        return(float)((base.Height * base.Height) * Math.PI);
    }
}
