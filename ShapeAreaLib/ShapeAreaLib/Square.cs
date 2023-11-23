using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Square
    {
        public double Area()
        {
            Console.WriteLine("Enter side of the Square ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the Square is : ");
            double area = a * a;
            return area;
        }
    }
}
