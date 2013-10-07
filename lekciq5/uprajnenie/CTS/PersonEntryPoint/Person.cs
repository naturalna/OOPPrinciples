using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    public string Name { get; set; }
    public sbyte? Age { get; set; }
    private StringBuilder sb;
    public Person(string name, sbyte? age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Person(string name)
        : this(name, null)
    {
    }
    public override string ToString()
    {
        sb = new StringBuilder();
        sb.Append("Person name is : " + this.Name);
        if (this.Age == null)
        {
            sb.Append("\nUnknown age");
        }
        else
        {
            sb.Append("\nPerson age is : " + this.Age);
        }
        return this.sb.ToString();
    }
}

