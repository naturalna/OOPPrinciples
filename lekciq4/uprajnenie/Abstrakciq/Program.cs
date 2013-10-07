using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstrakciq
{
    public interface IShape
    {
        void SetPosition(int x, int y);
    }
    public interface IMovable
    {
        void Move(int x, int y);
    }
    abstract class MovableShape : IShape, IMovable
    {
        private int x, y;
        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }
        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract int CalculateSurface();
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ignorirane na detaili koito ne sa swyrjani s konkretniqt obekt koito iskame da naprawim 
            //Abstractni klasowe - smesica m\u interfeis i metod i decata trqbwa da sa abstraktni
            // obiknowenno astraktniqt klas e bazow sam po sebesi ne moje da se izpolzwa
            // no moje da deklarira metodi , poleta i tem podobni + metodi koito trqbwa da imat naslednicite, no sa razli4ni za 
            //razli4nite naslednici Area za prawoygylnik ne e sy6tata kato za triygulni, no formata ima ob6ti ne6ta steni ygli
            // towa be6e smotan primer ama karai
            //
            //abstrakten tip danni IList primerno--> wseki koito go implementira trqbwa da moje da dobawq da maha elementi count insert i...
            // towa ne se interesuwa dali e list opa6ka i dr koito sa IList wikame si direktno IList i znaem 4e tezi ne6ta gi ima
        }
    }
}
