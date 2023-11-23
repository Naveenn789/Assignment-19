using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaLib
{
    public class Rectangle
    {
        public double Area()
        {
            Console.WriteLine("Enter length of the Rectangle : ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of the Rectangle : ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the Reactangle is : ");
            double area = a* b; 
            return area;
        }
    }
}
