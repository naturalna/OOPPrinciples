using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Block : GameObject
    {
        // towa e block
        public new const string CollisionGroupString = "block";
        // prawim construktor i pra6tame parametri kym bazowiqt klas
        public Block(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '#' } })
        {

        }

        public override void Update()
        {
            
        }
        // moje da se blyska s topki
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball";
        }
        // pri sblysyk gyrmi
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        // kato mu izwika6 get collision grup wry6ta string
        public override string GetCollisionGroupString()
        {
            return Block.CollisionGroupString;
        }
    }
}
