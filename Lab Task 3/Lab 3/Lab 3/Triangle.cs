using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Triangle
    {
        int x;
        int y;
        int z;
        public int getX()
        {
            return x;

        }
        public void setX(int X)
        {
            x = X;
        }

        public int getY()
        {
            return y;

        }
        public void setY(int Y)
        {
            y = Y;
        }
        public int getZ()
        {
            return z;

        }
        public void setZ(int Z)
        {
            z = Z;
        }
        public void ShowInfo()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);
        }
        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("The triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is Scaleme");
            }
        }
    }

}
