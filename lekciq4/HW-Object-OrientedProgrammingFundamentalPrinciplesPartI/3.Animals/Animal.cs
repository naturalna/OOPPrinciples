using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Animal : ISound
{
    public string Name { get; private set; }
    public ushort Age { get; private set; }
    public char Sex { get; private set; }

    public Animal(string name, ushort age, char sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }
    public void Say(string sound)
    {
        Console.WriteLine("{0}",sound);
    }
    public static double AvarageAge(Animal[] animals)
    {
        double sum = 0;
        foreach (var a in animals)
        {
            sum += a.Age;
        }
        return sum/animals.Length;
    }
}
