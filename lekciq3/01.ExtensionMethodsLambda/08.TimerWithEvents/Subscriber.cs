using System;

public class Subscriber
{
    public Subscriber(Publisher pub)
    {
        pub.RaiseCustomEvent += HandleCustomEvent;
    } 
    void HandleCustomEvent(object sender, CustemerEventArgs e)
    {
        Console.WriteLine("do Something at {0} msec", e.Seconds);
    }
}
