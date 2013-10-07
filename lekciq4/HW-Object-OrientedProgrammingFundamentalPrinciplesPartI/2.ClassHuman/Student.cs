using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Human
{
    private decimal grade;
    public decimal Grade
    {
        get { return this.grade; }
        set { this.grade = value; }
    }
    //method
    public IEnumerable<Student> SortPeople(List<Student> student)
    {
        var sortStudents = student.OrderBy(x => x.Grade).ThenBy(x => x.FirstName);
        return sortStudents;
    }
    //constructor
    public Student(string firsName, string secondName, decimal grade)
        : base(firsName, secondName)
    {
        this.Grade = grade;
    }
}

