using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExeptionsProba
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentException("My ex");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("This is my ex");
            }
            Console.WriteLine("After ex code");
            Console.WriteLine("this is  interesting");
        }
    }
}
