//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public delegate void CallMethod(int seconds);
class TimerEntryPoint
{
    static void Main()
    {
        int t = 3;
        CallMethod holdingDelegate= Timer.DoSomething;
        holdingDelegate(t);
    }
}

