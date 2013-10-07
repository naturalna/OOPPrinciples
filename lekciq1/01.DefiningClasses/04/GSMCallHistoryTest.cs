using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Ex.12

public class GSMCallHistoryTest
{
    public void GSMCallHistoryTests()
    {
        Battery battery = new Battery("BatteryModel", 50, 70, BatteryType.NiMH);
        Display display = new Display(20, 65000);
        GSM phone = new GSM("k50in", "Nokia", 999, "Petyrcho", battery, display);
        //calls
        DateTime day1 = new DateTime(2013,02,25,12,10,43);
        Call call1 = new Call(day1, "0888888888", 175);
        DateTime day2 = new DateTime(2013, 02, 25, 15, 10, 13);
        Call call2 = new Call(day2, "0888888888", 115);
        DateTime day3 = new DateTime(2013, 02, 25, 22, 18, 07);
        Call call3 = new Call(day3, "0888888888", 741);
        //Display the information about the calls.
        Console.WriteLine(call1);
        Console.WriteLine(call2);
        Console.WriteLine(call3);
        //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history
        // adding the calls in the call history
        phone.AddCalls(call1);
        phone.AddCalls(call2);
        phone.AddCalls(call3);
        // calculate the total price   
        Console.Write("Total price : ");
        Console.WriteLine(phone.TotalPrice(37));
        //Remove the longest call from the history and calculate the total price again.
        Console.Write("The longest call is : ");
        Console.WriteLine(phone.LongestCall.Duration);
        //removing the longest call
        phone.DeleteCall(phone.LongestCall);
        //total price without the longest call
        Console.Write("Total price without the longest call is : ");
        Console.WriteLine(phone.TotalPrice(37));
        //Finally clear the call history and print it
        phone.ClearCallHistory();
        //print
        Console.WriteLine("History : ");
        Console.WriteLine("   " +phone.CallHistory.Count);
        //The next will be better
    }
}

