using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public abstract class GameObject : IRenderable, ICollidable, IProducer//topka tyhla raketa
    {//IobjProduce-producira otlomki
        public const string CollisionGroupString = "object";
        //wseki obekt ni e matrica
        protected MatrixCoords topLeft;
        public MatrixCoords TopLeft
        {
            get
            {
                return new MatrixCoords(topLeft.Row, topLeft.Col);
            }

            protected set
            {
                this.topLeft = new MatrixCoords(value.Row, value.Col);
            }
        }
        //w body q kopirame
        protected char[,] body;
        // uni6tojena li e 
        public bool IsDestroyed { get; protected set; }
        // construktor na obektite
        protected GameObject(MatrixCoords topLeft, char[,] body)
        {
            // wytre6na matrica rawna na podadenta
            this.TopLeft = topLeft;

            int imageRows = body.GetLength(0);
            int imageCols = body.GetLength(1);
            // kopirame w body
            this.body = this.CopyBodyMatrix(body);
            // ne e uni6tojena
            this.IsDestroyed = false;
        }

        public abstract void Update();// sledwa6ta stypka

        public virtual List<MatrixCoords> GetCollisionProfile()
        {
            List<MatrixCoords> profile = new List<MatrixCoords>();

            int bodyRows = this.body.GetLength(0);
            int bodyCols = this.body.GetLength(1);

            for (int row = 0; row < bodyRows; row++)
            {
                for (int col = 0; col < bodyCols; col++)
                {
                    profile.Add(new MatrixCoords(row + this.topLeft.Row, col + this.topLeft.Col));
                }
            }
            // list ot matrici
            return profile;
        }
        // kak reagira pri sblysyk
        public virtual void RespondToCollision(CollisionData collisionData)
        {
        }
        //s kakwo se sblyskwa
        public virtual bool CanCollideWith(string otherCollisionGroupString)
        {
            return GameObject.CollisionGroupString == otherCollisionGroupString;
        }
        // ot koq grupa e 
        public virtual string GetCollisionGroupString()
        {
            return GameObject.CollisionGroupString;
        }
        //  kopirame body matrix mahame referenciqta
        char[,] CopyBodyMatrix(char[,] matrixToCopy)
        {
            int rows = matrixToCopy.GetLength(0);
            int cols = matrixToCopy.GetLength(1);

            char[,] result = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = matrixToCopy[row, col];
                }
            }

            return result;
        }

        public virtual MatrixCoords GetTopLeft()
        {
            return this.TopLeft;
        }
        // izpra6tame kopieto na body kato iskame izobrajenieto ni wry6ta negowoto kopie
        public virtual char[,] GetImage()
        {
            return this.CopyBodyMatrix(this.body);
        }
        // prawim list ot obekti 
        public virtual IEnumerable<GameObject> ProduceObjects()
        {
            return new List<GameObject>();
        }
    }
}
