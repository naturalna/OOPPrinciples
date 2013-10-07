using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

//Define a class that holds information about a mobile phone device: 
//model, manufacturer, price, owner, 
//battery characteristics (model, hours idle and hours talk) and 
//display characteristics (size and number of colors). 
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
public enum BatteryType
{
    LiIon, NiMH, NiCd
}
class CreatingGsm
{
    static void Main()
    {
        
        try
        {
            //adding battery type i the battery constructor
            Battery batteryOne = new Battery("SameModel", 10, 20, BatteryType.LiIon);
            Console.WriteLine("-------------------------EX3---------------------------");
            Console.WriteLine(batteryOne.Type);
            // creating phone
            Display displayOne = new Display(55f);
            GSM gsm = new GSM("55k33", "Nokia", 666, "Nqkoi", batteryOne, displayOne);
            // test for override method ToString()
            Console.WriteLine("-------------------------EX4---------------------------");
            Console.WriteLine(gsm.ToString());
            Console.WriteLine("-------------------------EX.7--------------------------");
            //creating object test
            GSMTests test = new GSMTests();
            test.Tests();//call its method  It is void method so it will directly write the data  
            //ex.9
            Console.WriteLine("------------------------EX9---------------------------");
            string dateTime ="22.12.2013 01.05.35";
            
            DateTime day = DateTime.ParseExact(dateTime, "dd.MM.yyyy HH.mm.ss", CultureInfo.InvariantCulture);//date
            string dateTime2 = "20.12.2013 01.05.35";
            DateTime day2 = DateTime.ParseExact(dateTime2, "dd.MM.yyyy HH.mm.ss", CultureInfo.InvariantCulture);//date
            Call firstCall = new Call(day,"0555555555",78);
            Call secondCall = new Call(day2, "0555555555", 105);
            Console.WriteLine(firstCall.DateAndTime);
            gsm.AddCalls(firstCall);
            gsm.AddCalls(secondCall);
            Console.WriteLine();
            Console.WriteLine(gsm.CallHistory[0].DateAndTime);
            Console.WriteLine(gsm.CallHistory[1].DateAndTime);
            Console.WriteLine("------------------------EX10--------------------------");
            gsm.DeleteCall(secondCall);
            for (int i = 0; i < gsm.CallHistory.Count; i++)
            {
                 Console.WriteLine(gsm.CallHistory[i].DateAndTime);
            }
            gsm.ClearCallHistory();
            Console.WriteLine("There is {0} call in the call history",gsm.CallHistory.Count);
            Console.WriteLine("--------------------------EX12------------------------");
            GSMCallHistoryTest testHistory = new GSMCallHistoryTest();
            testHistory.GSMCallHistoryTests();

           
        }
        catch (ArgumentException exep)
        {
            Console.WriteLine("There is incorrect data!");
            Console.WriteLine(exep.ToString());
        }
    }
}

