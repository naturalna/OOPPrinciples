//Write a method that from a given array of students finds all students whose first name 
//is before its last name alphabetically. Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StudentsNameAndLINQ
{
    static void Main()
    {
        //Array of AnonymousTypes
        var studentsNames =new[] {new {firstName= "Petyr", lastName="Petrow"},
                                  new {firstName= "Wasil", lastName="Atanasow"},
                                  new {firstName= "Asen", lastName="Simeonow"}
                                    };
        var searchedNames =
            from names in studentsNames
            where names.firstName.CompareTo(names.lastName) < 0
            select names;
        foreach (var item in searchedNames)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

