using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Shape : ICalculatable
{
    protected float Width { get; set; }
    protected float Height { get; set; }
    protected Shape(float width, float height)
    {
        this.Width = width;
        this.Height = height;
    }
    public abstract float CalculateSurface();
 
}

