using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_JessieJi
{
    
    struct Desk
    {
        private int width, depth, numDrawers;
        public int Width { get { return width; } set { width = value; } }
        public int Depth { get { return depth; } set { depth = value; } }
        public int NumDrawers { get { return numDrawers; } set { numDrawers = value; } }
        public SurfaceMaterial SurfMaterial;
        public Desk(int w, int d, int nd) : this()
        {
            Width = w;
            Depth = d;
            NumDrawers = nd;
        }

        public enum SurfaceMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }
    }

    
    
}
