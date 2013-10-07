using System;
using System.Collections.Generic;
using System.Text;


    public interface IRenderer
    {
        void EnqueueForRendering();// zapis w pametta

        void RenderAll();// narisuwai wsi4ki

        void ClearQueue();// iz4isti opa6ka buferyt
    }

