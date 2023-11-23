using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Circle
    {
        public double Area()
        {
            Console.WriteLine("Enter radius of the Circle ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the Circle is : ");
            double area = 3.14*r*r ;
            return area;
        }
    }
}
