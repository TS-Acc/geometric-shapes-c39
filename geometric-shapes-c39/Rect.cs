using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39
{
    internal class Rect
    {

        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public int Perimeter()
        {
            return (Side1 + Side2) * 2;
        }

        public int Area()
        {
            return Side1 * Side2;
        }

        public Rect() { }

        public Rect (int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

    }
}
