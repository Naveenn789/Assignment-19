using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Triangle
    {
        public double Area(double Base, double height)
        {
            double area = (Base * height)/2;
            return area;
        }
    }
}
