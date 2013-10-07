using System;
using System.Collections.Generic;
using System.Text;

public class Classes : ICommentable
{
    //indentifier of the class
    private String className;
    public String ClassName
    {
        get { return this.className; }
        set { this.className = value; }
    }
    private string comment;
    // Student in class
    private IList<Students> student;
    public IList<Students> Student
    {
        get { return this.student; }
        set { this.student = value; }
    }
    // set of teachers
    private IList<Teachers> setOfTeachers;
    public IList<Teachers> SetOfTeachers
    {
        get { return this.setOfTeachers; }
        set { this.setOfTeachers = value;}
    }
    //constructors
    public Classes(string className, IList<Students> student,IList<Teachers> teacher)
    {
        this.ClassName = className;
        this.Student = student;
        this.SetOfTeachers = teacher;
        this.comment = "";
    }
    //comments
    private StringBuilder sbForComments;
    public StringBuilder SbForComments
    {
        get { return this.sbForComments; }
        set { this.sbForComments = value; }
    }
    public void Comment(string text)
    {
        this.comment = text;
    }
    public string SayComment()
    {
        sbForComments = new StringBuilder();
        sbForComments.Append("I am class :" + this.ClassName);
        sbForComments.Append("\n" + "My coment is : \n");
        sbForComments.Append(comment);
        return sbForComments.ToString();
    }
    private StringBuilder sbForToString;
    public StringBuilder SbForToString
    {
        get { return this.sbForToString; }
        set { this.sbForToString = value; }
    }
    public override string ToString()
    {
        sbForToString = new StringBuilder();
        sbForToString.Append("Class name : " + className +"\n");
        for (int i = 0; i < student.Count; i++)
        {
            sbForToString.Append(Student[i].ToString());
        }
        for (int j = 0; j < SetOfTeachers.Count; j++)
        {
            sbForToString.Append(SetOfTeachers[j].ToString());
        }
        return sbForToString.ToString();
    }
}

