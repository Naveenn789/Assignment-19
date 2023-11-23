using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace ConAppRealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area of the Reactangle is : ");
            Console.WriteLine(rectangle.Area(10, 20));
            Square square = new Square();
            Console.WriteLine("Area of the Square is : ");
            Console.WriteLine(square.Area(10));
            Circle circle = new Circle();
            Console.WriteLine("Area of the Circle is : ");
            Console.WriteLine(circle.Area(7));
            Triangle triangle = new Triangle();
            Console.WriteLine("Area of the Triangle is : ");
            Console.WriteLine(triangle.Area(20, 30));

            Console.ReadKey();

        }
    }
}
