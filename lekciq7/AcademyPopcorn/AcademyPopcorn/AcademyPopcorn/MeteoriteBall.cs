using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed): base(topLeft,speed)
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> l = new List<GameObject>();
            l.Add(new TrailObject(this.TopLeft,new char[,]{{'x'}},4));
            return l;
        }
        public override void Update()
        {
        }
    }
}
