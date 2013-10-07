using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public interface IRenderer
    {
        void EnqueueForRendering(IRenderable obj);// zapis w pametta

        void RenderAll();// narisuwai wsi4ki

        void ClearQueue();// iz4isti opa6ka buferyt
    }
}
