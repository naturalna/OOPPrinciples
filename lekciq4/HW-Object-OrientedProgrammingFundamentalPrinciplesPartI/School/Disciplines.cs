using System;
using System.Collections.Generic;
using System.Text;

public class Disciplines : ICommentable
{
    // name of the disciplines
    private string discName;
    public string DiscName
    {
        get { return this.discName; }
        set { this.discName = value; }
    }
    private string comment;
    //number of lectures
    private int numberOfLectures;
    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set { this.numberOfLectures = value; }
    }
    //number of exercises
    private int numberOfExercises;
    public int NumberOfExercises
    {
        get { return this.numberOfExercises; }
        set { this.numberOfExercises = value; }
    }
    private StringBuilder sb;
    public StringBuilder Sb
    {
        get { return this.sb; }
        set { this.sb = value; }
    }
    //constructor
    public Disciplines(string disiplinesName, int numberOFLectures,int numberOfExercises)
    {
        this.DiscName = disiplinesName;
        this.NumberOfLectures = numberOFLectures;
        this.NumberOfExercises = numberOfExercises;
    }
    // interface
    public void Comment(string text)
    {
        this.comment = "Discipline :" + this.discName + "\ncomment : " + text;
    }
    public string SayComment()
    {
        return this.comment;
    }
    public override string ToString()
    {
        Sb = new StringBuilder();
        Sb.Append(this.DiscName+ ", ");
        Sb.Append(this.NumberOfLectures+ ", ");
        Sb.Append(this.NumberOfExercises);
        return Sb.ToString();
    }
}
