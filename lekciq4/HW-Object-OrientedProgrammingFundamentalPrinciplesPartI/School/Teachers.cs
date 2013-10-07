using System;
using System.Collections.Generic;
using System.Text;

public class Teachers : Person, ICommentable
{
    
    private IList<Disciplines> setOfDisciplines;
    public IList<Disciplines> SetOfDisciplines
    {
        get
        {
            return this.setOfDisciplines;
        }
        set
        {
            this.setOfDisciplines = value;
        }
    }
    private StringBuilder sb;
    public StringBuilder Sb
    {
        get { return this.sb; }
        set { this.sb = value; }
    }
    // constructor
    public Teachers(string name, IList<Disciplines> setOfDisciplines): base(name)
    {
        this.SetOfDisciplines = setOfDisciplines;
    }
    private string comment;// it is visible only here I don`t need property
    public void Comment(string text)
    {
        this.comment = base.SayName() + "\n Here is my comment : \n" + text;
    }
    // encapsulation
    public string SayComment()
    {
        return comment;
    }
    public override string ToString()
    {
        Sb = new StringBuilder();
        Sb.Append(base.Name +" : ");
        for (int i = 0; i < SetOfDisciplines.Count; i++)
        {
            Sb.Append(SetOfDisciplines[i].ToString() + " and ");
        }
        Sb.Remove(Sb.Length - 4,3);
        Sb.Append("\n");
        return Sb.ToString();
    }
}

