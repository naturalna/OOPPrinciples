using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Human
{
    public string FirstName
    {
        get;
        set;
    }
    public string SecondName
    {
        get;
        set;
    }
    public Human(string firstName, string secondName)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
    }
    public void MergePeople(List<Student> students, List<Worker> workers)
    {
        List<string> allPeople = new List<string>();
        foreach (var names in students)
        {
            allPeople.Add(names.FirstName + " " + names.SecondName);
        }
        foreach (var names in workers)
        {
            allPeople.Add(names.FirstName + " " + names.SecondName);
        }
        var sortNames = allPeople.OrderBy(x => x);
        int i = 1;
        foreach (var name in sortNames)
        {
            Console.WriteLine("{0}: {1}",i,name);
            i++;
        }
    }
    //overload ToString
    // this will work for students and workers
    public override string ToString()
    {
        return this.FirstName + " "+ this.SecondName;
    }
}
