using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student
{
    virtual public string Name { get; set; }
    public int baseProp { get; set; }
}
public class Dete : Student
{
    public override string Name
    {
        get
        {
            return base.Name+"II";
        }
        set
        {
            base.Name = value;
        }
        
    }
    public int childProp { get; set; }
}
