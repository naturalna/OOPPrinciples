using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

public class Call
{
    private DateTime dateAndTime;
    private string dialedPhoneNumber;
    private int duration;
    public DateTime DateAndTime
    {
        get { return this.dateAndTime; }
        protected set
        {
            this.dateAndTime = value;
        }
    }
    public string DialedPhoneNumber
    {
        get { return this.dialedPhoneNumber; }
        protected set
        {
            if (value.Length != 10)
            {
                throw new ArgumentException("Not valid phone number!");
            }
            this.dialedPhoneNumber = value;
        }
    }
    public int Duration
    {
        get { return this.duration; }
       protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid duration!");
            }
            this.duration = value;
        }
    }
    //constr.
    public Call()
        : this(new DateTime(1, 1, 1, 1, 1, 1),"0000000000",0)
    {
     
    }
    public Call(DateTime dateAndtime, string dailedPhoneNumber,int duration)
    {
        this.DateAndTime = dateAndtime;
        this.DialedPhoneNumber = dailedPhoneNumber;
        this.Duration = duration;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Date and time of the call : ");
        sb.Append(this.dateAndTime + "\n");
        sb.Append("Dailed number : ");
        sb.Append(this.DialedPhoneNumber + "\n");
        sb.Append("Duration : ");
        sb.Append(this.Duration);

        return sb.ToString();
    }
}

