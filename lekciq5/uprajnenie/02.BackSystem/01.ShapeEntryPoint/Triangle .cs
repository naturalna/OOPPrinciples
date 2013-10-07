using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Triangle : Shape
{
    public Triangle(float width, float height)
        : base(width,height)
    {
    }
    public override float CalculateSurface()
    {
        return (base.Width * base.Height) / 2;
    }
}

