using System;

public class Publisher
{
    public event EventHandler<CustemerEventArgs> RaiseCustomEvent;
    protected virtual void OnRaiseCustomEvent(CustemerEventArgs e)
    {
        EventHandler<CustemerEventArgs> handler = RaiseCustomEvent;
        if (handler != null)
        {
            handler(this, e);
        }
    }
    public void DoSomething(CustemerEventArgs e)
    {
        do
        {
            OnRaiseCustomEvent(e);
            System.Threading.Thread.Sleep(e.Seconds);
        } while (true);
    }
}

