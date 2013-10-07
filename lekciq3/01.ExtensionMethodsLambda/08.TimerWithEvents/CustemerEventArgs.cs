using System;

public class CustemerEventArgs : EventArgs
{
    private int seconds;
    public int Seconds
    {
        get { return this.seconds; }
        set { this.seconds = value; }
    } 
    public CustemerEventArgs(int seconds)
    {
        this.Seconds = seconds;
    }
}

