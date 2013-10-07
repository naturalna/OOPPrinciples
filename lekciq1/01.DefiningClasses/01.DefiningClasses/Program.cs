using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Define a class that holds information about a mobile phone device: 
//model, manufacturer, price, owner, 
//battery characteristics (model, hours idle and hours talk) and 
//display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
// the same code is in project 04.Gsm.You can check it from there
public enum BatteryType
{
    LiIon, NiMH, NiCd
}
public class GSM
{   
    public readonly string Model;//property
    public readonly string Manifacturer;//property
    //fields
    private decimal? price;
    private string owner;
    public Battery Battery;
    public Display Display;
    // properties
    //public string Model
    //{
        //get { return this.model; }
        //you can not change them .You can only create them through the constructor
        //protected set
        //{
        //    if (value.Length > 20)
        //    {
        //        throw new ArgumentException("Wrong model");
        //    }
        //    else
        //    {
        //        this.model = value;
        //    }
        //}
    //}
    //public string Manifacturer
    //{
    //    get { return this.manifacturer; }
    //   // protected set { this.manifacturer = value; }
    //}
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
            if (value !=null)
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
        : this(model, manifacturer, null, null,new Battery(),new Display())
    {
    }
    public GSM(string model, string manifacturer,decimal? price)
        : this(model, manifacturer, price, null, new Battery(), new Display())
    {
    }
    public GSM(string model, string manifacturer, string owner)
        : this(model, manifacturer, null, owner, new Battery(), new Display())
    {
    }
    public GSM(string model,string manifacturer,decimal? price, string owner,Battery battery,Display display)
    {
        this.Model = model;
        this.Manifacturer = manifacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
    }

}
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
        set
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
            if (value <=0 )
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
    public Battery(string model,short? hourIdle,short? hourTalk,BatteryType type)
    {
        this.Model = model;
        this.HourIdle = hourIdle;
        this.HourTalk = hourTalk;
        this.type = type;
    }
}
public class Display
{
    private float size;
    private int? numberOfColors;
    public float Size
    {
        get { return this.size; }
        protected set { this.size = value; }
    }
    public int? NumbersOfColors
    {
        get { return this.numberOfColors; }
        protected set { this.numberOfColors = value; }
    }
    //constructors
    public Display()
        : this(0.0f, null)
    {
    }
    public Display(float size)
        : this(size,null)
    {
    }
    public Display(int? numbersOfColors)
        : this(0.0f, numbersOfColors)
    {
    }
    public Display(float size, int? numberOfColors)
    {
        this.Size = size;
        this.NumbersOfColors = numberOfColors;
    }
}
class Program
{
    static void Main()
    {
        GSM mobile = new GSM("sk50", "samsung");
        Console.WriteLine("The model is : {0}",mobile.Model);
        Console.WriteLine("Manifacturer : {0}",mobile.Manifacturer);
        Console.WriteLine("Price : {0}",mobile.Price);
        Console.WriteLine("Owner : {0}",mobile.Owner);
        Console.WriteLine( mobile.Battery.Model);
        // sam.Model = "ggg"; //readonly is working
        //sam.Owner = "fsef"; // property is working
        GSM mobileTwo = new GSM("m55kin", "Nokia", 220);
        Console.WriteLine("Second constructor :------------------------------------------------------------");
        Console.WriteLine("The model is : {0}", mobileTwo.Model);
        Console.WriteLine("Manifacturer : {0}", mobileTwo.Manifacturer);
        Console.WriteLine("Price : {0}", mobileTwo.Price);
        Console.WriteLine("Owner : {0}", mobileTwo.Owner);
        GSM mobileThree = new GSM("m55kin", "Nokia", "Mariika");
        Console.WriteLine("Thrid constructor :-------------------------------------------------------------");
        Console.WriteLine("The model is : {0}", mobileThree.Model);
        Console.WriteLine("Manifacturer : {0}", mobileThree.Manifacturer);
        Console.WriteLine("Price : {0}", mobileThree.Price);
        Console.WriteLine("Owner : {0}", mobileThree.Owner);
        Console.WriteLine("Thrid constructor :-------------------------------------------------------------");
        Battery LiIon = new Battery("LiIon",10,30,BatteryType.NiCd);
        Console.WriteLine(LiIon.Type);
        Display display = new Display(17f);
        GSM mobileFour = new GSM("m55kin", "Nokia", 456,"Mariika",LiIon,display);
        Console.WriteLine("The model is : {0}", mobileFour.Model);
        Console.WriteLine("Manifacturer : {0}", mobileFour.Manifacturer);
        Console.WriteLine("Price : {0}", mobileFour.Price);
        Console.WriteLine("Owner : {0}", mobileFour.Owner);
        //there is a littel problem with the battery and the display :)
        Console.WriteLine("Battery-model : {0}",mobileFour.Battery.Model);
        Console.WriteLine("Dyslpay size : {0}",mobileFour.Display.Size);
        
        
    }
}

