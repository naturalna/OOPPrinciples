using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GenericExample
{
    static void Main()
    {
        try
        {
            GenericList<int> list = new GenericList<int>(5);
            list.Add(1);
            list.Add(2);
            list.Add(1);
            Console.Write("Add : ");
            Console.WriteLine(list.ToString());
            list.Remove(1);
            Console.Write("Remove : ");
            Console.WriteLine(list.ToString());
            list.Insert(3, 555);
            Console.Write("Insert : ");
            Console.WriteLine(list.ToString());
            Console.Write("Clear : ");
            list.ClearList();
            Console.WriteLine(list.ToString());
            Console.WriteLine("Searching element by its value");
            list.Add(1);
            list.Add(2);
            list.Add(1);
            list.Add(2);
            list.Insert(2, 3);
            Console.WriteLine(list.ToString());
            int indexOfElement = list.FindElement(1, 1);
            Console.WriteLine(indexOfElement);
        }
        catch (ArgumentOutOfRangeException exp)
        {
            Console.WriteLine("Error!");
            Console.WriteLine(exp);
        }   
    }
}

