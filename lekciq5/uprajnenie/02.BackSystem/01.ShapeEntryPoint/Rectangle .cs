using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangle: Shape
{
    public Rectangle(float width, float height)
        : base(width, height)
    {
    }
    public override float CalculateSurface()
    {
        return base.Height * base.Width;
    }
}

