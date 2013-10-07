using System;

public class Display
{
    private float? size;
    private int? numberOfColors;
    public float? Size
    {
        get { return this.size; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("The display size is wrong");
            }
            this.size = value;
        }
    }
    public int? NumbersOfColors
    {
        get { return this.numberOfColors; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("The display colors are wrong !");
            }
            this.numberOfColors = value;
        }
    }
    //constructors
    public Display()
        : this(null, null)
    {
    }
    public Display(float? size)
        : this(size, null)
    {
    }
    public Display(int? numbersOfColors)
        : this(null, numbersOfColors)
    {
    }
    public Display(float? size, int? numberOfColors)
    {
        this.Size = size;
        this.NumbersOfColors = numberOfColors;
    }
}