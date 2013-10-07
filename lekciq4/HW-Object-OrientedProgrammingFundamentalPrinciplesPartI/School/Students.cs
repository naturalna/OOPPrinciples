using System;
using System.Collections.Generic;
using System.Text;

public class Students : Person, ICommentable
{
    private int studentNumber;
    public int StudentNumber
    {
        get { return this.studentNumber; }
        set { this.studentNumber = value; }
    }
    private string comment;
    private StringBuilder sb;
    public StringBuilder Sb
    {
        get { return this.sb; }
        set { this.sb = value; }
    }
    //constructor
    public Students(string name, int number)
        : base(name)
    {
        this.StudentNumber = number;
        this.comment = "";
    }
    // interface for comment
    
    public void Comment(string text)
    {
        Console.WriteLine("Here is my comment : ");
        Console.WriteLine(text);
        comment = base.SayName() + "\nHere is my comment : \n"+text;
    }
    public string SayComment()
    {
        return comment;
    }
    public override string  ToString()
    {
        Sb = new StringBuilder();
        Sb.Append("student name : "+base.Name+" , student number: ");
        Sb.Append(this.StudentNumber+"\n");
 	    return Sb.ToString();
    }
}

