using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   public class Game : IPlayer
    {
       // ot game
        public int PropForGame { get; set; }
       public void Metod(IPlayer a,IPlayer b)
       {
           // polzwat se kato typ i tozi tip trqbwa da ima metodite koito ima w interfeisa
           // a metodite se pi6at w otdelen klas koito nasledqwa : IPlayer i gi opiswa
       }
       // nadolu sa ot interfeisa
       // towa e ot abstrakciqta- ne se interesuwam dali e student ili ne6to drugo a ot towa 4e moje da prawi ne6to
       public string Name
       {
           get { return "ani"; }
       }

       public void Start()
       {
           Console.WriteLine("Start");
       }
    }

