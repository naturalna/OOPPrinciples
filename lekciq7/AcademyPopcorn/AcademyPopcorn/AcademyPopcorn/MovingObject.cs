using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MovingObject : GameObject
    {    //prop skorost- w koordinati
        public MatrixCoords Speed { get; protected set; }
        // construktor
        public MovingObject(MatrixCoords topLeft, char[,] body, MatrixCoords speed)
            : base(topLeft, body)
        {
            this.Speed = speed;
        }
        // updeit na poziciqta mestim top left s nqkakwa skorost 
        protected virtual void UpdatePosition()
        {
            this.TopLeft += this.Speed;
        }
        // wikame updeita koito wika update position
        public override void Update()
        {
            this.UpdatePosition();
        }
    }
}
