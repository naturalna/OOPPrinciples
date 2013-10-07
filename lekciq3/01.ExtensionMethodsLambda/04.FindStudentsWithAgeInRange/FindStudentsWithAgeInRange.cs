//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FindStudentsWithAgeInRange
{
    static void Main()
    {
        var students = new[] { new{FirstName ="Sam",LastName ="Simson",Age =23},
                               new{FirstName ="Asen",LastName ="Grigorow",Age =18},
                               new{FirstName ="Kaloqn",LastName ="KaraStoqnow",Age =52},
                             };
        var selectedNames =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student.FirstName +" "+ student.LastName;
        foreach (var name in selectedNames)
        {
            Console.WriteLine(name);   
        }
    }
}

