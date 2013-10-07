//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes 
//Triangle and Rectangle that implement the virtual method and return the surface of the figure (height*width for rectangle and 
//height*width/2 for triangle). Define class Circle and suitable constructor so that at initialization height must be kept equal to
//width and implement the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method for
//different shapes (Circle, Rectangle, Triangle) stored in an array.

using System;

class ShapeEntryPoint
{
    static void Main()
    {
        Shape[] shapeArray = new Shape[]
        {
            new Circle(5.3f),
            new Rectangle(5,3),
            new Triangle(8.3f,1)
        };
        foreach (var shapeInArr in shapeArray)
        {
            Console.WriteLine(shapeInArr.CalculateSurface());
        }
    }
}

