using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Extation
{
    public static StringBuilder Substring(this StringBuilder sb, int index, int length)
    {
        StringBuilder strBuilder = new StringBuilder();
        for (int i = index; i <= length; i++)
        {
            strBuilder.Append(sb[i]);
        }
        return strBuilder;
    }
}


