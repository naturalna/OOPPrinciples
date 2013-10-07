using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
   public class TrailObject : GameObject 
    {
       public new const string CollisionGroupString = "TrailObject";
       public int lifeTime { get; set; }
       public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime): base(topLeft,body)
       {
           this.lifeTime = lifeTime;
       }

       public override void Update()
       {
           lifeTime--; 
           if (lifeTime == 0)
           {
               this.IsDestroyed = true;
           }
       }
       public override void RespondToCollision(CollisionData collisionData)
       {
       }
       // kato mu izwika6 get collision grup wry6ta string
       public override string GetCollisionGroupString()
       {
           return TrailObject.CollisionGroupString;
       }
    }
}
