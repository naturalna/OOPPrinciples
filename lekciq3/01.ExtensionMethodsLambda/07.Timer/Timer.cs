using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public static class Timer
{
    public static void DoSomething(int sec)
    {
        do
        {
            Thread.Sleep(sec * 1000);
            Console.WriteLine("This is the method that will be execute at each {0} seconds", sec);
        } while (true);
        
    }
}

