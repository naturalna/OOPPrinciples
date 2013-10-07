using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class AutoGrowArray
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
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Insert(1, 8);
            list.Insert(1, 8);
            Console.WriteLine(list.ToString());
            int indexOfElement = list.FindElement(6,1);
            Console.WriteLine(indexOfElement);
            Console.WriteLine(list.Min<string>());
            Console.WriteLine(list.Max<int>());
        }
        catch (ArgumentOutOfRangeException exp)
        {
            Console.WriteLine("Error!");
            Console.WriteLine(exp);
        }
    }
}

