//* Read in MSDN about the keyword event in
// C# and how to publish events. Re-implement the above using .NET events and following the best practices

using System;

namespace EventsEntryPoint
{
    class TimerWithEvents
    {
        static void Main(string[] args)
        {
            Publisher publish = new Publisher();
            Subscriber sub = new Subscriber(publish);
            CustemerEventArgs arg = new CustemerEventArgs(3000);
            publish.DoSomething(arg);
        }
    }
}
