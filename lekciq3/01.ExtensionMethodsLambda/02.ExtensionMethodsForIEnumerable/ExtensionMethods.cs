using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ExtensionMethods
{
    private static T Common<T>(this IEnumerable<T> col, Func<T,T,T> comp)
    {
        IEnumerator<T> enumerator = col.GetEnumerator();
        if (enumerator.MoveNext() == false)// po4wa ot -1
        {
            throw new ArgumentException("Collection Empty!");
        }
        dynamic temp = enumerator.Current;
        while (enumerator.MoveNext())
        {
            temp = comp(temp, enumerator.Current);
            // (x,y) => corc1.Add(croc2); you can use it for your own class if you have override operator + / *
            // temp = temp + next;
        }
        return temp;
    }
    public static T GetSum<T>(this IEnumerable<T> col, Func<T,T,T> sumator)
    {
        return Common<T>(col, sumator);
    }
    public static T GetProduct<T>(this IEnumerable<T> col, Func<T, T, T> product)
    {
        return Common<T>(col, product);
    }
    public static T GetCompare<T>(this IEnumerable<T> col, Func<T, T, T> result)
    {
        return Common<T>(col, result);
    }
    //----------------------It is working too but it is not very good----------------------
    public static T Sum<T>(this IEnumerable<T> dataList)
        where T : IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic sum = default(T);
        foreach (T data in dataList)
        {
            sum = sum + data;
        }
        return sum;      
    }
    //----------------------It is working too but it is not very good----------------------
    public static T Product<T>(this IEnumerable<T> dataList)
        where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic product = 1;
        foreach (T data in dataList)
        {
            product = product * data;
        }
        return product;      
    }
    //---------------------min and max---------------------
    public static T Min<T>(this IEnumerable<T> dataList)
        where T : IComparable
    {
        T minValue = dataList.First();
        foreach (T data in dataList)
        {
            if (minValue.CompareTo(data)== 1)
            {
                minValue = data;
            }
        }
        return minValue;//to ask for a better way    
    }
    public static T Max<T>(this IEnumerable<T> dataList)
        where T : IComparable
    {
        T maxValue = dataList.First();
        foreach (T data in dataList)
        {
            if (maxValue.CompareTo(data) == -1)
            {
                maxValue = data;
            }
        }
        return maxValue; 
    }
 
    public static T Average1<T>(this IEnumerable<T> dataList)
     where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        dynamic result = dataList.Sum();
        double count = dataList.Count();
        return (result /count) ;
    }
}

