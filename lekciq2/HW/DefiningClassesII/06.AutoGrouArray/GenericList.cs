//Ex.5 Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in
//the class constructor. Implement methods for adding element, accessing element by index, removing
//element by index, inserting element at given position, clearing the list, finding element by its 
//value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GenericList<T>
    where T : IComparable
{
    private int arrCapacity;
    public int ArrCapacity
    {
        get { return this.arrCapacity; }
        set
        {
            this.arrCapacity = value;
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("The capacity of the array must be positive number");
            }
        }
    }
    private T[] holdArray;
    public T[] HoldArray
    {
        get { return this.holdArray; }
        protected set { this.holdArray = value; }
    }
    private int count = 0;
    public GenericList(int arrCapacity)
    {
        this.ArrCapacity = arrCapacity;
        HoldArray = new T[ArrCapacity];
    }
    //adding elements in the end of the list| arr
    public void Add(T element)
    {
        if (count > ArrCapacity - 1)
        {
            throw new ArgumentOutOfRangeException("There is no free cells");
        }
        HoldArray[count] = element;
        count++;
        if (count == ArrCapacity)
        {
            AutoGrow();
        }
    }
    //indexer
    public T this[int index]
    {
        get
        {
            return this.HoldArray[index];
        }
        set
        {
            if (index > ArrCapacity - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException("There is no such index");
            }
            this.HoldArray[index] = value;
        }
    }
    //remove element by index
    public void Remove(int indexForRemove)
    {
        if (indexForRemove < 0 || indexForRemove > ArrCapacity - 1)
        {
            throw new ArgumentOutOfRangeException("There is no such index");
        }
        for (int i = indexForRemove; i < ArrCapacity - 1; i++)
        {
            HoldArray[i] = HoldArray[i + 1];
        }
        count--;
    }
    //inserting element at given position.The last one element is lost if the array is full
    public void Insert(int indexForInsert, T number)
    {
        if (count == ArrCapacity)
        {
          AutoGrow();
        }
        for (int i = ArrCapacity - 2; i >= indexForInsert; i--)
        {
            T num;
            num = HoldArray[i];
            HoldArray[i + 1] = num;
        }
        HoldArray[indexForInsert] = number;
        count++;
    }
    //clearing the list
    public void ClearList()
    {
        Array.Clear(HoldArray, 0, ArrCapacity);
        count = 0;
    }
    //finding element by its value
    public int FindElement(T element, int startIndex = 0)
    {
        for (int i = startIndex; i < ArrCapacity; i++)
        {
            if (HoldArray[i].CompareTo(element) == 0)
            {
                return i;
            }
        }
        return -1;
    }
    //ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < ArrCapacity; i++)
        {
            sb.Append(HoldArray[i] + ",");
        }
        return sb.ToString();
    }
    private void AutoGrow()
    {
        ArrCapacity = ArrCapacity * 2;
        T[] copyArray = new T[ArrCapacity];
        for (int i = 0; i < ArrCapacity/2; i++)
        {
            copyArray[i] = HoldArray[i];
        }
        HoldArray = new T[ArrCapacity];
        for (int i = 0; i < ArrCapacity/2; i++)
        {
            HoldArray[i] = copyArray[i];
        }
    }
    //Ex7
    public T Min<T1>()
        where T1: IComparable<T1>
    {
        dynamic minElement = HoldArray[0];
        for (int i = 1; i < count; i++)
        {
            if (HoldArray[i].CompareTo(minElement) == -1)
            {
                minElement = HoldArray[i];
            }
        }
        return minElement;
    }
    public T Max<T1>()
        where T1 : IComparable<T1>
    {
        dynamic maxElement = HoldArray[0];
        for (int i = 1; i < count; i++)
        {
            if (HoldArray[i].CompareTo(maxElement) == 1)
            {
                maxElement = HoldArray[i];
            }
        }
        return maxElement;
    }
}

