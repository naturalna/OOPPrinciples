using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
//3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by
//social security number (as second criteria, in increasing order).

public class Student : ICloneable,IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }
    public int SSN { get; private set; }
    public string Address { get; private set; }
    public int MobilePhone { get; private set; }
    public string Course { get; private set; }
    public Universities Uni { get; private set; }
    public Specialty Spec { get; private set; }
    public Faculty FAC { get; set; }
    private StringBuilder sb;
    //constructor
    public Student(string firstName, string middleName, string lastName,
        int SSN, string addres, int mobilePhone, string course, Universities uni, Specialty specialty, Faculty fac)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = SSN;
        this.Address = addres;
        this.MobilePhone = mobilePhone;
        this.Course = course;
        this.Uni = uni;
        this.Spec = specialty;
        this.FAC = fac;      
    }
    public Student()
    {
    }
    //override
    public override bool Equals(object studentTwo)
    {
        Student student2 = studentTwo as Student;
        if (student2 == null)
        {
            throw new NullReferenceException("There is no other student");
        }
        if (student2.SSN == this.SSN)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    // override ==
    public static bool operator ==(Student student1, Student student2)
    {
        return Equals(student1, student2);
    }
    // override !=
    public static bool operator !=(Student student1, Student student2)
    {
        return !(Equals(student1, student2));
    }
    //GetHashCode ??
    public override int GetHashCode()
    {
        //I can write something else
        return FirstName.GetHashCode() ^ LastName.GetHashCode();
        //return base.GetHashCode();
    }
    //override ToString
    public override string ToString()
    {
         this.sb = new StringBuilder();
        sb.Append(this.FirstName + " " + this.LastName);
        sb.Append("\n" + this.Uni + " " + this.FAC);
        return this.sb.ToString();
    }
    //ex 2
    public object Clone()
    {
        Student cloneStudent = new Student();
        cloneStudent.FirstName = this.FirstName;
        cloneStudent.MiddleName = this.MiddleName;
        cloneStudent.LastName = this.LastName;
        cloneStudent.SSN = this.SSN;
        cloneStudent.Address = this.Address;
        cloneStudent.MobilePhone = this.MobilePhone;
        cloneStudent.Course = this.Course;
        cloneStudent.Uni = this.Uni;
        cloneStudent.Spec = this.Spec;
        cloneStudent.FAC = this.FAC;
        //string builder with params of the copy ,not the origin
        StringBuilder cloneSB = new StringBuilder();
        //It is making new string builder in mathod ToString so we don't need this 
        //but I want to be sure
        cloneStudent.sb = cloneSB;
        return cloneStudent;
    }
    object ICloneable.Clone()
    {
        return this.Clone();
    }
    //ex.3
    public int CompareTo(Student otherStudent)
    {
        //first we compare the first names and if they are not the same we return in lexicographic order the first
        if (this.FirstName != otherStudent.FirstName )
        {
            // you have compare to for strings 
            return this.FirstName.CompareTo(otherStudent.FirstName);
        }
        // if the first names are the same we check middle names
        if (this.MiddleName != otherStudent.MiddleName)
        {
            return this.MiddleName.CompareTo(otherStudent.MiddleName);
        }
        if (this.LastName != otherStudent.LastName)
        {
            return this.LastName.CompareTo(otherStudent.LastName);
        }
        //social security number (as second criteria, in increasing order).
        // the smaller number is first
        if (this.SSN != otherStudent.SSN)
        {
            return (this.SSN - otherStudent.SSN);
        }
        //and finaly if everything is =
        return 0;
    }
}

