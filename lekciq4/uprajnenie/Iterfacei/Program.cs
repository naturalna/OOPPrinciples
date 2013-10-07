using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterfacei
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            //moga da dosytq wsi4ki propyrtita i metodi ot game 
            // no iskam prosto da ima Name propyrti ne me interesuwa dali e igra ili 4owek ili ne6to drugo moga da izpolzwam direktno
            // interfeisyt
            IPlayer pl = new Game();
            // i taka dosytpwam samo metodi i swoistwa na interfeisyt koito sa napisani w Gama ,no tezi koito sa ot game ne moga da gi 
            // dostypq 
        }
    }
}
