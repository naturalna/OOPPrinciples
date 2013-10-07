using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Matrix<T>
    where T : IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
//Iformatable- it will have ToString()
//IComparable -it will have CompareTo()
//IEquatable -it will have Equal()
{
    public T[,] MyArr { get; set; }
    private int row;
    public int Row
    {
        get { return this.row; }
        protected set { this.row = value; }
    }
    private int coll;
    public int Coll
    {
        get { return this.coll; }
        protected set { this.coll = value; }
    }
    //constr
    public Matrix(int row, int col)
    {
        this.Coll = col;
        this.Row = row;
        MyArr = new T[Row, Coll];
    }
    //method for adding
    public void Add(int row, int col, T number)
    {
        MyArr[row - 1, col - 1] = number;
    }
    //indexer
    public T this[int row, int coll]
    {
        get { return this.MyArr[row, coll]; }
        set
        {
            this.MyArr[row, coll] = value;
        }
    }
    //overload +
    public static Matrix<T> operator +(Matrix<T> firtsMat, Matrix<T> secondMat)
    {
        Matrix<T> result = new Matrix<T>(firtsMat.Row, firtsMat.Coll);
        if (firtsMat.Row != secondMat.Row || firtsMat.Coll != secondMat.Coll)
        {
            throw new ArgumentException("The matrix has different size");
        }
        for (int i = 0; i < firtsMat.Row; i++)
        {
            for (int j = 0; j < firtsMat.Coll; j++)
            {
                result[i, j] = (dynamic)firtsMat[i, j] + secondMat[i, j];
            }
        }
        return result;
    }
    // overload -
    public static Matrix<T> operator -(Matrix<T> firtsMat, Matrix<T> secondMat)
    {
        Matrix<T> result = new Matrix<T>(firtsMat.Row, firtsMat.Coll);
        if (firtsMat.Row != secondMat.Row || firtsMat.Coll != secondMat.Coll)
        {
            throw new ArgumentException("The matrix has different size");
        }
        for (int i = 0; i < firtsMat.Row; i++)
        {
            for (int j = 0; j < firtsMat.Coll; j++)
            {
                result[i, j] = (dynamic)firtsMat[i, j] - secondMat[i, j];
            }
        }
        return result;
    }
    //overload *
    public static Matrix<T> operator *(Matrix<T> firtsMat, Matrix<T> secondMat)
    {
        Matrix<T> result = new Matrix<T>(firtsMat.Row, firtsMat.Coll);
        if (firtsMat.Row != secondMat.Row || firtsMat.Coll != secondMat.Coll)
        {
            throw new ArgumentException("The matrix has different size");
        }
        for (int r = 0; r < firtsMat.Row; r++)
        {
            for (int j = 0; j < firtsMat.Row; j++)
            {
                dynamic sum = 0;
                for (int c = 0; c < firtsMat.Coll; c++)
                {
                    sum += (dynamic)firtsMat[r, c] * secondMat[c, j];
                }
                result[r, j] = sum;
            }
        }
        return result;
    }
    //override ToString()
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int rows = 0; rows < this.Row; rows++)
        {
            for (int colls = 0; colls < this.Coll; colls++)
            {
                sb.Append(MyArr[rows, colls] + " ");
            }
            sb.Append("\n");
        }
        return sb.ToString();
    }
    //overload true
    // if there is 0 in one of the cells the oerator is true
    //I am not very sure what I must do.
    public static bool operator true(Matrix<T> firtsMat)
    {
        bool flag = true;
    
        for (int rows = 0; rows < firtsMat.Row; rows++)
        {
            for (int colls = 0; colls < firtsMat.Coll; colls++)
            {
                if ((dynamic)firtsMat[rows, colls] == 0)
                {
                    flag = false;
                    return flag; ;
                }
            }
        }
            return flag;     
    }
    public static bool operator false(Matrix<T> firtsMat)
    {
        bool flag = true;

        for (int rows = 0; rows < firtsMat.Row; rows++)
        {
            for (int colls = 0; colls < firtsMat.Coll; colls++)
            {
                if ((dynamic)firtsMat[rows, colls] == 0)
                {
                    flag = false;
                    return flag;
                }
            }
        }
            return flag;
    }
}
