using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Racket : GameObject
    {
        public new const string CollisionGroupString = "racket";

        public int Width {get; protected set;}

        public Racket(MatrixCoords topLeft, int width) : base(topLeft, new char[,]{{'='}})
        {
            this.Width = width;
            this.body = GetRacketBody(this.Width);
        }
        // forma na ryketata
        char[,] GetRacketBody(int width)
        {
            char[,] body = new char[1, width];

            for (int i = 0; i < width; i++)
            {
                body[0, i] = '_';
            }

            return body;
        }
        // metod na lqwo 
        public void MoveLeft()
        {
            this.topLeft.Col--;
        }
        // metod na dqsno
        public void MoveRight()
        {
            this.topLeft.Col++;
        }
        // wry6ta si grupata
        public override string GetCollisionGroupString()
        {
            return Racket.CollisionGroupString;
        }
        //s kakwo gyrmi
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block" || otherCollisionGroupString == Racket.CollisionGroupString || otherCollisionGroupString == "ball";
        }
        // update zaradi poziciqta 
        public override void Update()
        {
        }
    }
}
