using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//5.Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), 
//GetHashCode(), [], == and !=.

class BitArray64EntryPoint
{
    static void Main()
    {
        BitArray64 num = new BitArray64(8);
        int count = 63;
        foreach (var item in num)
        {
            Console.Write(count + " Bit :");
            Console.WriteLine(item);
            count--;
        }
        //indexer
        Console.WriteLine(num[0]);
        Console.WriteLine(num[1]);
        Console.WriteLine(num[3]);
        //equals
        BitArray64 number1 = new BitArray64(654);
        BitArray64 number2 = new BitArray64(223);
        Console.WriteLine(number1.Equals(number2));
        BitArray64 number3 = new BitArray64(223);
        Console.WriteLine(number2.Equals(number3));
        Console.WriteLine(number3 == number2);

    }
}

