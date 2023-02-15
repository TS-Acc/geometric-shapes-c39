using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace geometric_shapes_c39
{
    internal class MathLib
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if(y == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
                return -1;
            }
            return x / y;

        }

        public static int Square(int x)
        {
            return x * x;
        }

        public static int Cube(int x)
        {
            return x * x * x;
        }

        //public static int SquareOfNumber(int x, int y)
        //{
        //    int toThePowerOf = y.ToString().Length;

        //    for(int idx = 0; idx <= toThePowerOf; idx++)
        //    {
        //        int multiplyByX = 
        //    }
        //}
    }
}
