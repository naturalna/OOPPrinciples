using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
public class GSM
{

    public readonly string Model;//property
    public readonly string Manifacturer;//property
    //fields
    private static GSM iPhone4S = new GSM("ModelIphone", "ManifactorerIphone", 666m, "OwnerIphone");//ex 6
    private decimal? price;
    private string owner;
    private Battery Battery;
    private Display Display;
    private List<Call> callHistory;
    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { this.callHistory = value;}
    }
    //longest call form ex 12
    private Call longestCall = new Call(new DateTime(1,1,1,1,1,1),"0000000000",0);
    public Call LongestCall
    {
        get { return this.longestCall; }
        set { this.longestCall = value; }
    }
    public static string IPhone4S
    {
        get { return iPhone4S.ToString(); }
    }
    public decimal? Price
    {
        get { return this.price; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Not valid price!");
            }
            this.price = value;
        }
    }
    public string Owner
    {
        get { return this.owner; }
        protected set
        {
            if (value != null)
            {
                if (value.Length > 60)
                {
                    throw new ArgumentException("Your name is too long!");
                }
            }
            this.owner = value;
        }
    }
    public GSM(string model, string manifacturer)
        : this(model, manifacturer, null, null, new Battery(), new Display())
    {
    }
    public GSM(string model, string manifacturer, decimal? price)
        : this(model, manifacturer, price, null, new Battery(), new Display())
    {
    }
    public GSM(string model, string manifacturer, string owner)
        : this(model, manifacturer, null, owner, new Battery(), new Display())
    {
    }
    public GSM(string model, string manifacturer, decimal? price, string owner)
        : this(model, manifacturer, price, owner, new Battery(), new Display())
    {
    }
    public GSM(string model, string manifacturer, decimal? price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manifacturer = manifacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
        this.CallHistory = new List<Call>();
    }
    //ex.4
    //method
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append("Model : ");
        output.Append(this.Model);
        output.Append("\n");
        output.Append("Manifacturer : ");
        output.Append(this.Manifacturer);
        output.Append("\n");
        output.Append("Price : ");
        output.Append(this.Price);
        output.Append("\n");
        output.Append("Owner : ");
        output.Append(this.Owner);
        output.Append("\n");
        output.Append("Battery : ");
        output.Append(this.Battery.Model);
        output.Append("\n");
        output.Append("Display : ");
        output.Append(this.Display.Size);
        return output.ToString();
    }
    public void AddCalls(Call call)
    {
        CallHistory.Add(call);
        if (call.Duration > LongestCall.Duration)
        {
            this.LongestCall = call;
        }
    }
    //Ex.10
 
    public void DeleteCall(Call call)
    {
        CallHistory.Remove(call);
    }
    public void ClearCallHistory()
    {
        CallHistory.Clear();
    }
    //Ex.11
    public decimal TotalPrice(decimal pricePerMin)
    {
        decimal totalDuration = 0;
        for (int i = 0; i < CallHistory.Count; i++)
        {
            totalDuration += CallHistory[i].Duration;
        }
        return (totalDuration/60 * pricePerMin)/100;
    }
}