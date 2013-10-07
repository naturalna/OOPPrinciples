using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//4.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so. 
//sWrite a program to test this functionality.

class PersonEntryPoint
{
    static void Main()
    {
        Person person1 = new Person("Ivan", 66);
        Console.WriteLine(person1.ToString());
        Person person2 = new Person("Petko");
        Console.WriteLine(person2.ToString());
    }
}

