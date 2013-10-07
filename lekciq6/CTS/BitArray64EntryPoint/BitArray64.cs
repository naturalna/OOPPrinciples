using System;
using System.Collections.Generic;
using System.Collections;

public class BitArray64 : IEnumerable<int>
{
    public ulong Number { get; set; }
    private ulong mask;
    public BitArray64(ulong num)
    {
        this.Number = num;
    }
    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 63; i >= 0; i--)
        {
            yield return this[i];//new BitArray64
        }
    }
    //IEnum has current MoveNext and restet
    IEnumerator IEnumerable.GetEnumerator()
    {
        //call GetEnumerator for int
        return this.GetEnumerator();
    }
    //indexer[]
    //show bit at index
    public int this[int i]
    {
        get
        {
            mask = 1;
            mask = mask << i;
            if ((mask & this.Number) == mask)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    //equals
    //classes can have value null
    public override bool Equals(object numberTwo)
    {
        BitArray64 numberForCompare = numberTwo as BitArray64;
        if (numberForCompare == null)
        {
            throw new NullReferenceException("There is no second number");
        }
        if (numberForCompare.Number == this.Number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //get hash code
    public override int GetHashCode()
    {
        return (this.Number ^ 5).GetHashCode();
    }
    // ==
    public static bool operator ==(BitArray64 firstNum, BitArray64 secondNum)
    {
        return BitArray64.Equals(secondNum,firstNum);
    }
    //!=
    public static bool operator !=(BitArray64 fNum, BitArray64 sNum)
    {
        return !(fNum.Equals(sNum));
    }
}

