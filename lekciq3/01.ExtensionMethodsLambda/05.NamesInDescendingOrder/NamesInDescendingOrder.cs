//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
//first name and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NamesInDescendingOrder
{
    static void Main()
    {
        var studentsNames = new[] {new {firstName= "Petyr", lastName="Petrow"},
                                  new {firstName= "Wasil", lastName="Atanasow"},
                                  new {firstName= "Asen", lastName="Simeonow"}
                                    };
        var ordered =
            studentsNames.OrderByDescending(x => x.firstName).ThenByDescending(x => x.lastName);
    }
}

