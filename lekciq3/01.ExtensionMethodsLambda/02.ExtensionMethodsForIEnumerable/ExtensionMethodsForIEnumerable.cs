//Implement a set of extension methods for IEnumerable<T> that 
//implement the following group functions: 
//sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program 
{
    static void Main()
    {
        int[] arr = new int[] { 1, 2, 3,3};
        
        Console.WriteLine(arr.Sum());
        string[] strArr = new string[] { "ba", "bb", "c" };
       // Console.WriteLine(strArr.Sum());
       //// date time doesn`t work
       // Console.WriteLine(arr.Product());
       // Console.WriteLine(strArr.Min());//letter by letter , the numbers are first
     

        Console.WriteLine(new String('-',30));
        Console.WriteLine("Sum");
        Console.WriteLine(arr.GetSum<int>((x,y)=>x+y));
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("Product for numbers");
        Console.WriteLine(arr.GetProduct<int>((x, y) => x * y));
        Console.WriteLine(new String('-', 30));
        Console.WriteLine("min for strings");
        Console.WriteLine(arr.GetSum<int>((x, y) => x * y));
        Console.WriteLine("Compare for numbers");
        //Console.WriteLine(new String('-',30));
        //Console.WriteLine(arr.GetCompare<int>((x,y) =>x.CompareTo(y)));
        Console.WriteLine(arr.Average());
        //It is working too but I do not like it 
        Console.WriteLine(arr.Max());
        Console.WriteLine(strArr.Max());
       
    }
}

