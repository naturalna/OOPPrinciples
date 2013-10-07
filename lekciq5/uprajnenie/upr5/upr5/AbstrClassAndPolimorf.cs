using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Figure   
{
    // AbstrClassAndPolimorf
    // reglamentiran method
    public virtual void Drow()
    {
        Console.WriteLine("I am unknow figure");
    }

    // tuk moje da ima i abstraktni methodi no ne mis e pi6at metod za cwqt na figurata
    public ConsoleColor Getcolor()
    {
        // towa powedenie na metoda w se wnimawa pri override
        // mojem da si go promenqme bez da go overridvame .wse edno e now metod i si rabotim s obekt ot tipyt w koito si go pi6em nowiqt metod
        // no sys sy6toto ime si wzima nego ,no ako go izwikame Figure f = new Prawoygylnik nqma da raboti s metodyt ot Prawoygylnik a ot figure
        return ConsoleColor.Red;
    }
}
