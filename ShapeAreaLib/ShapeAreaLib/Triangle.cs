using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Triangle
    {
        public double Area()
        {
            Console.WriteLine("Enter Base of the Traingle : ");
            double Base = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of the Traingle : ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the Triangle is : ");
            double area = (Base * height)/2;
            return area;
        }
    }
}
