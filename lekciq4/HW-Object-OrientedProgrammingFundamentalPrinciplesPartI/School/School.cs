using System;
using System.Collections.Generic;
using System.Text;

public class School
{
    public IList<Classes> Classes { get; set; }
    private StringBuilder sb;
    public StringBuilder Sb
    {
        get { return this.sb; }
        set { this.sb = value; }
    }
    public School(IList<Classes> classes)
    {
        this.Classes = classes;
    }
    public override string ToString()
    {
        Sb = new StringBuilder();
        Sb.Append("The School have this classes : \n");
        for (int i = 0; i < Classes.Count; i++)
        {
            Sb.Append(Classes[i].ToString());
        }
        return Sb.ToString();
    }
}

