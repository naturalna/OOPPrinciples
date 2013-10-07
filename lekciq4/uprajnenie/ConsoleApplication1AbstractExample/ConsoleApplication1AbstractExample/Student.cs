using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class Student : Human
    {
        public int Grade { get; protected set; }

        public Student(string aFirstName, string aSecondName, int aGrade) : base(aFirstName, aSecondName)
        {
            this.Grade = aGrade;
        }

    }

