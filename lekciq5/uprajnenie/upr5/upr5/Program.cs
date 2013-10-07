using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        // 1.polimorfizym- sposobnostta na daden obekt da priema powe4e ot 1 forma(overridvane na virtualni methodi)
        // ili polimorfizym e daden obekt na e powe4e ot 1 tip.Prevozno sredstwo(kola,motor).s metod kolko gumi ima6 .ili mai e swoistwo
        // swoistwoto kolko gumi ima6 e polimorfno.Plimorfizyt e da izpolzwa6 IList primerno.Dostypwa6 naprawo bazowiqt tip s edna duma
        // IList e interfeis de ama i za bazowi tipowe stawa.Mojem da naprawim EDIN spisyk, w koito da
        // ima wsqkywi prezowni sredstwa koli kamioni.List<object> :) hitro
        // wirtualnite metodi mogat da se overridwat s naslednicite,pri tezi mojem,a pri abstractnite sme zadyljeni
        // virtualnite metodi mogat da se promenqt izcqlo s dumata new
        // Ta polimorfizmyt e Figure g = new Circle ili new Pravoygylnik ili..
        // towa w momentyt e polimorfizyt i abstrakciq za6toto rabotim s bazow klas 
        // 2.Class hierarhi
        // ako imame controla nqkakwa- kalkulatoryt-butoni meniu i tem podobni sa kontroli
        // kato imame kontrola zna4i imame ili bazow asbtracten klas ili intrefais buton
        // wsi4ki kontroli mogat da se risuwat imame interfeis IRisuvable
        // kogato imame ob6ti swoista goworin za bazow kalas kogato goworim za ob6ta funkcionalnost goworim za o6te interfeis
        // ob6ti swoista sa poziciqta na butona i towa wliza w bazowiqt klas kontrol
        // w kontrowa meniu mojem da imame controla butoni ako imame takiwa kontroli w koito ima deca kontroli si prawim konteiner
        // t.e. kogato imame daden klas koito dobawq dopylnitelna funkcionalnost kym we4e sy6t klas i tozi klas se nasledqwa ot 
        // drugi klasowe(toi e konteiner s edna duma)
        // BEZ ProPYRTITA w interfeisa
        // 3.exeption handling
        // 4.Cohesion and Coupling
        // Figure f = new Figure() - ne moje
        Figure f = new Prawoygylnik();
        Console.WriteLine(f.Getcolor());
        Prawoygylnik f1 = new Prawoygylnik();

        // ne sym mn sigurna 4e towa e mn prawilno
        Console.WriteLine(f1.Getcolor());
    }
}
