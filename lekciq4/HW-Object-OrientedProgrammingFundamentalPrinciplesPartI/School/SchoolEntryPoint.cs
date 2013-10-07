//We are given a school. In the school there are classes of students. 
//Each class has a set of teachers. Each teacher teaches a set of disciplines.
//Studen have name and unique class number. Classes have unique text identifier.
//Teachers have name. Disciplines have name, number of lectures and number of exercises. 
//Both teachers and students are people. Studen, classes, teachers and disciplines 
//could have optional comments (free text block). Your task is to identify the classes 
//(in terms of  OOP) and their attributes and operations, encapsulate their fields, define the
//class hierarchy and create a class diagram with Visual Studio.

using System;
using System.Collections.Generic;

class SchoolEntryPoint
{
    static void Main()
    {
       // creating teachers
       // we need e set of discip
        Disciplines disc1 = new Disciplines("Math", 23, 140);
        Disciplines disc2 = new Disciplines("Biology", 23, 140);
        Disciplines disc3 = new Disciplines("OOP", 23, 140);
        IList<Disciplines> disciplines = new List<Disciplines>();
        disciplines.Add(disc1);
        disciplines.Add(disc2);
        disciplines.Add(disc3);
        //disciplines can have comments
        disc1.Comment("I am free this week");
        // and that is the teacher with his disciplines
        Teachers teacher1 = new Teachers("Petrow",disciplines);
        //he can make comments
        teacher1.Comment("Ivancho is bad");
        //you can see his comment
        Console.WriteLine(teacher1.SayComment());
        //we can make second teacher and than a set of teachers
        Teachers teacher2 = new Teachers("Stoqnow", disciplines);
        IList<Teachers> setOfTeachers = new List<Teachers>();
        setOfTeachers.Add(teacher1);
        setOfTeachers.Add(teacher2);
        // to create a class we need and a set of students
        // first we create a few students
        Students student1 = new Students("Ivancho", 7);
        Students student2 = new Students("Mariika", 16);
        Students student3 = new Students("Qworcho",25);
        IList<Students> setOfStudents = new List<Students>();
        setOfStudents.Add(student1);
        setOfStudents.Add(student2);
        setOfStudents.Add(student3);
        // now we can ctreate class
        Classes class1 = new Classes("10b", setOfStudents, setOfTeachers);
        // the classes can make comments
        class1.Comment("We are happy class");
        // finaly we make a list of classes
        Classes class2 = new Classes("11v",setOfStudents,setOfTeachers);
        IList<Classes> setOfClasses = new List<Classes>();
        setOfClasses.Add(class1);
        setOfClasses.Add(class2);
        //school
        School school1 = new School(setOfClasses);
        Console.WriteLine(school1.ToString());
    }
}
