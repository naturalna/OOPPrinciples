using System;

public class Person
{
    // people have name
    private string name;
    protected string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    // constructor that can not be called 
    protected Person(string name)
    {
        this.Name = name;
    }
    protected Person():this("No Name")
    {
    }
    // method for saying name
    protected string SayName()
    {
        return ("My name is : " + this.Name).ToString();
    }
}

