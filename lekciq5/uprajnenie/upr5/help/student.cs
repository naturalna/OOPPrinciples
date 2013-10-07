using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class students
{
    public string Name { get; set; }
    public string LName { get; set; }
    public int Age { get; set; }
    public students(string name, string sname, int age)
    {
        this.Name = name;
        this.LName = sname;
        this.Age = age;
    }
}