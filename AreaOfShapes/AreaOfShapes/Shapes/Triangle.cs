using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfShapes.Shapes
{
    public class Triangle: Interfaces.IShape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public double Area
        {
            get
            {
                var p = (Side1 + Side2 + Side3) / 2;
                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
        }

        public Triangle()
        {
            Side1 = Side2 = Side3 = default(int);
        }

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public bool IsRightTriangle()
        {
            return (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2))
                || Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2))
                || Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)));
        }
    }
}
