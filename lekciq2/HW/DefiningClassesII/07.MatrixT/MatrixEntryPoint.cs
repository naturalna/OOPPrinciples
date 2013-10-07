using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class MatrixEntryPoint
{
    static void Main()
    {
       Matrix<int> matrix1= new Matrix<int>(3,3);
       matrix1.Add(1, 1, 3);
       //Matrix<bool> boolMatrix = new Matrix<bool>(3, 3); //It can NOT be bool
       //Matrix<StreamReader> stringMatrix = new Matrix<StreamReader>(3, 3);//It can NOT be string
       Matrix<float> mat = new Matrix<float>(2, 2);
       mat[0, 0] = 1;
       mat[0, 1] = 3;
       mat[1, 0] = 0;
       mat[1, 1] = -2;
       Matrix<float> mat2 = new Matrix<float>(2, 2);
       mat2[0, 0] = 7;
       mat2[0, 1] = 9;
       mat2[1, 0] = 5;
       mat2[1, 1] = 2;
       Matrix<float> result = new Matrix<float>(2, 2);
       result = mat * mat2;
       Console.WriteLine(result.ToString());
       if (mat2)
       {
           Console.WriteLine("The matrix is with non-zero elements");
       }
       else
       {
           Console.WriteLine("There is 0 in some of the cells");
       }
    }
}
