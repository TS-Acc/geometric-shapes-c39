using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39
{
    internal class Sqr : Rect // Sqr is now a devired class of Rect which is a derived class of Quad
                              // Sqr inherits all public methods and properties of Quad and of Rect 
    {

        public Sqr() : base() { } // when we call the base constructor Rect it then calls the base constructor Quad

        public Sqr(int side1) : base(side1, side1)
        {

        }

    }
}
