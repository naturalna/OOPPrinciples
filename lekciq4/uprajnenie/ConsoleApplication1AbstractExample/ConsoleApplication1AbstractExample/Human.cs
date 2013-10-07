using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public abstract class Human
    {
        public string FirstName { get;  set; }
        public string SecondName { get;  set; }

        public Human(string aFirstName, string aSecondName)
        {
            this.FirstName = aFirstName;
            this.SecondName = aSecondName;
        }
    }

