//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;

class ExtationMethodsAndLambda
{
    static void Main()
    {
        int[] arr = new int[] { 2, 3, 7, 21, 45, 121 };
        Func<int,bool> lambdaF = ((x)=> (x % 3 == 0)||( x % 7 == 0));
        var result = arr.Where(lambdaF);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        var newResult =
            from num in arr
            where num % 3 == 0 || num % 7 == 0
            select num;
        foreach (var item in newResult)
        {
            Console.WriteLine(item);
        }
    }
}

