using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class InvalidRangeException<T> : ApplicationException
{
    public T RangeUp { get; private set; }
    public T RangeDown { get; private set; }
    public InvalidRangeException(string msg, T downRange, T upRange)
        : base(msg)
    {
        this.RangeUp = upRange;
        this.RangeDown = downRange;
    }
    public override string Message
    {
        get
        {
            string result = string.Format("{0} range of numbers is :{1}-{2}", base.Message, this.RangeDown, this.RangeUp);
            return result;
        }
    }

}

