using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile 
//phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("nameF", "nameM", "nameFam", 555, "Address", 033, "FA",
       Universities.Universities1, Specialty.Specialty2, Faculty.Faculty3);
        Student student2 = new Student("nameF", "nameM", "nameFam", 555, "Address", 0331, "FA",
           Universities.Universities1, Specialty.Specialty2, Faculty.Faculty3);
        //It is looking for same ssn
        Console.WriteLine("Are the students equal?");
        Console.WriteLine(student1.Equals(student2));
        //!=
        Console.WriteLine(student1 != student2);
        //to string
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine(student1.ToString());
        Console.WriteLine("Clone----------------------------------------------------------------");
        // firstName is not private because I want to try this things
        Student clStudent= student1.Clone() as Student;
        //check for first and last name of the clone student
        Console.WriteLine(clStudent.FirstName);
        Console.WriteLine(clStudent.LastName);
        //check for string builder used in ToString
        Console.WriteLine(clStudent.ToString());
        //check what will happen if I rename fistrName of  the clone student
        clStudent.FirstName = "RenameName";
        Console.WriteLine("Rename--------------------------------------------------------------");
        Console.WriteLine("The original name is :{0}",student1.FirstName);
        Console.WriteLine("The new name is      :{0}",clStudent.FirstName);
        //you can not have two people with same SSN, but in this case You can :) 
        Console.WriteLine(clStudent.Equals(clStudent));
        Console.WriteLine("Rename and ToString------------------------------------------------");
        Console.WriteLine(clStudent.ToString());
        Console.WriteLine("");
        Console.WriteLine("Ex.3---------------------------------------------------------------");

        Student student3 = new Student("A", "nameM", "nameFam", 455, "Address", 033, "FA",
       Universities.Universities1, Specialty.Specialty2, Faculty.Faculty3);
        Student student4 = new Student("A", "nameM", "nameFam", 555, "Address", 0331, "FA",
           Universities.Universities2, Specialty.Specialty2, Faculty.Faculty2);
        if (student3.CompareTo(student4)== 0)
        {
            Console.WriteLine("Student3 is equal to student4");
        }
        else if (student3.CompareTo(student4) < 0)
        {
            Console.WriteLine("It must be in lexicographic order ");
            Console.WriteLine("First student is : {0}",student3);
            Console.WriteLine("Second student is: {0}",student4);
        }
        else
        {
            Console.WriteLine("It must be in lexicographic order ");
            Console.WriteLine("First student is : {0}", student4);
            Console.WriteLine("Second student is: {0}", student3);
        }
    }
}

