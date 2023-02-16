using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39
{
    internal class Rect : Quad // Rect is now a derived class of Quad
    {

        public virtual int Area()
        {
            return Side1 * Side2;
        }

        public Rect() : base() { }

        public Rect (int side1, int side2) : base(side1, side2, side1, side2)
        {

        }

    }
}
