//Write extension method to the String class that capitalizes the first letter of each word. Use the method TextInfo.ToTitleCase().
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string text = "text and other text";
        TextInfo myTI = CultureInfo.CurrentCulture.TextInfo;
        string result = myTI.ToTitleCase(text);
        Console.WriteLine(result);
    }
}

