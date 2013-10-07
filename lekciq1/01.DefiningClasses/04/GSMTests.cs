using System;
using System.Collections.Generic;

public class GSMTests
{
    private string[] models =
    {
        "Nokia","Samsung","LG"
    };// private feild
    private string[] manifacturers = 
    {
        "manifacturerOne","manifacturerTwo","manifacturerthree"
    };
    private string[] owners = 
    {
        "OwnerOne","OwnerTwo","OwnerThree"
    };
    private decimal[] price =
    {
        299,677,677
    };
    private Battery[] battery = 
    {
        new Battery("bateryModel1",20,30,BatteryType.NiMH),
        new Battery("bateryModel2",20,30,BatteryType.NiCd),
        new Battery("bateryModel2",20,30,BatteryType.LiIon)
    };
    private Display[] display = 
    {
        new Display(23,568977),
        new Display(15,65255),
        new Display(20,655555)
    };
    public void Tests()//protected method
    {
        for (int i = 0; i < 3; i++)
        {
            GSM phone = new GSM(this.models[i], this.manifacturers[i], this.price[i], this.owners[i], this.battery[i], this.display[i]);
            Console.WriteLine(phone.ToString());
            Console.WriteLine("");
        }
        Console.WriteLine("Iphone4S ---------------------------------- ");
        Console.WriteLine(GSM.IPhone4S);
    }
}
