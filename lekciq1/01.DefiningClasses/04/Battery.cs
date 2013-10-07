using System;
public class Battery
{
    private string model;
    private short? hourIdle;
    private short? hourTalk;

    private BatteryType type;//field
    public BatteryType Type//propertie
    {
        get { return this.type; }
    }

    public string Model
    {
        get { return this.model; }
        protected set
        {
            if (value != null)
            {
                if (value.Length > 40)
                {
                    throw new ArgumentException("The model of battery is wrong");
                }
            }
            this.model = value;
        }
    }
    public short? HourIdle
    {
        get { return this.hourIdle; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("HourIdle is not correct !");
            }
            else
            {
                this.hourIdle = value;
            }
        }
    }
    public short? HourTalk
    {
        get { return this.hourTalk; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The hours of talk are not correct !");
            }
            else
            {
                this.hourTalk = value;
            }
        }
    }
    //constructors
    public Battery()
        : this(null, null, null, BatteryType.LiIon)
    {
    }
    public Battery(string model, short hourTalk)
        : this(model, null, hourTalk, BatteryType.LiIon)
    {
    }
    public Battery(string model, short? hourIdle, short? hourTalk, BatteryType type)
    {
        this.Model = model;
        this.HourIdle = hourIdle;
        this.HourTalk = hourTalk;
        this.type = type;
    }
}

