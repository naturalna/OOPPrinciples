//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].Write a sample application that demonstrates the 
//InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in
//the range [1.1.1980 … 31.12.2013].

using System;

class InvalidRangeExceptionEP
{
    static void Main(string[] args)
    {
        int[] arrInt = new int[] { 1, 5, 6, 200, 3 };
        // create new exeption for int
        InvalidRangeException<int> intEx = new InvalidRangeException<int>("invalid data", 1, 100);
        try
        {
            foreach (var number in arrInt)
            {
                if (number < intEx.RangeDown || number > intEx.RangeUp)
                {
                    throw intEx;
                }
            }
        }
        catch (InvalidRangeException<int> msg)
        {
            Console.WriteLine(msg);
        }
        //create new exeption for date time
        DateTime[] arrDateTime = new DateTime[]
        {
            new DateTime(1980,1,11),
            new DateTime(2000,2,14),
            new DateTime(2013,1,8),
            new DateTime(2014,12,31),
        };
        InvalidRangeException<DateTime> dateTimeExeption =
        new InvalidRangeException<DateTime>("Invalid date", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
        try
        {
            foreach (var date in arrDateTime)
            {
                if (date.CompareTo(dateTimeExeption.RangeDown) < 0 || date.CompareTo(dateTimeExeption.RangeUp) > 0)
                {
                    throw dateTimeExeption;
                }
            }
        }
        catch (InvalidRangeException<DateTime> msg)
        {
            Console.WriteLine(msg);
        }
    }
}

