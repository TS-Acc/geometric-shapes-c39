using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39
{
    internal class Sqr
    {
        public int Side1 { get; set; }

        public int Perimeter()
        {
            return Side1 * 4;
        }

        public int Area()
        {
            return Side1 * Side1;
        }

        public Sqr() { }

        public Sqr(int side1)
        {
            Side1 = side1;
        }

    }
}
