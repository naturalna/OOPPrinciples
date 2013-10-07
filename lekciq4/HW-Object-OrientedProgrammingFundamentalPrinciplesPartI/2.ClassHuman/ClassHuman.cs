//2.Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – 
//grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
//that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. 
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by 
//first name and last name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ClassHuman
{
    static void Main()
    {
        // creating 10 first names
        string[] firstNames = new string[]
        {
            "Anton","Vlado","Mariq","Ivan","Stoqn","Valq","Gergana","Petq","Rosica","Kaloqn"
        };
        // 10 last names
        string[] lastNames = new string[]
        {
            "Antonow","Vladimirom","Martinowa","Ivanow","Stoqnow","Valentinowa","Georgiewaa","Petrowa","Rokowska","Kaloqnow"
        };
        // 10 graded
        decimal[] grades = new decimal[]
        {
            5.33m,4.81m,6.00m,5.18m,3.26m,6.00m,5.87m,4.65m,5.33m,3.78m
        };
        List<Student> studentsList = new List<Student>();
        for (int i = 0; i < 10; i++)
        {
            studentsList.Add(new Student(firstNames[i], lastNames[i], grades[i]));
        }
        //not sorted students
        Console.WriteLine("----------------------Not sorted list-------------------------\n");
        foreach (var firstName in studentsList)
        {
            Console.WriteLine(firstName +"---grade---"+firstName.Grade);
        }
       // sort the students
        Console.WriteLine("");
        Console.WriteLine("-----------------------Sorted list--------------------------\n");
        //creating new student and using the method
       Student student0 = new Student("", "", 0m);
       var sortStudentView = student0.SortPeople(studentsList);
       foreach (var item in sortStudentView)
       {
           Console.WriteLine(item);
       }
       Console.WriteLine("");
       Console.WriteLine("--------------------------Workers-------------------------------\n");
       // creating 10 first names
       string[] fNames = new string[]
        {
            "Anton","Vlado","Mariq","Ivan","Stoqn","Valq","Gergana","Petq","Rosica","Kaloqn"
        };
       // 10 last names
       string[] lNames = new string[]
        {
            "Antonow","Vladimirom","Martinowa","Ivanow","Stoqnow","Valentinowa","Georgiewaa","Petrowa","Rokowska","Kaloqnow"
        };
       // 10 graded
       decimal[] weekSalary = new decimal[]
        {
            120m,150m,600m,518m,326m,600m,587m,465m,533m,378m
        };
       int[] workHours = new int[]
        {
            10,10,10,10,10,10,10,10,10,10
        };
       List<Worker> workersList = new List<Worker>();
       for (int j = 0; j < 10; j++)
       {
           workersList.Add(new Worker(fNames[j], lNames[j], weekSalary[j], workHours[j]));
       }
       Console.WriteLine("---------------------Not sorted workers-------------------------\n");
       foreach (var workerName in workersList)
       {
           Console.WriteLine(workerName + "---MoneyPerHour---{0:0.00}",workerName.MoneyPerHour());
       }
       Console.WriteLine("-------------------------Sorted workers-------------------------\n");
       Worker worker0 = new Worker("", "", 0m, 0);
       var sortWorkers= worker0.SortPeople(workersList);
       foreach (var workerN in sortWorkers)
       {
           Console.WriteLine(workerN);
       }
        // it can be called from class worker and from class student
       //student0.MergePeople(studentsList, workersList);
       worker0.MergePeople(studentsList, workersList);
    }
}

