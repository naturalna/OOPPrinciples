//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtetionsEntryPoint
{
    static void Main()
    {
        StringBuilder strBuilder = new StringBuilder();
        strBuilder.Append("here is same test text");
        StringBuilder result = new StringBuilder();
        result = strBuilder.Substring(0, 21);
        Console.WriteLine(result.ToString());
    }
}

