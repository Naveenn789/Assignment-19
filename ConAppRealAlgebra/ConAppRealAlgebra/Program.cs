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
            Console.WriteLine(rectangle.Area());
            Square square = new Square();           
            Console.WriteLine(square.Area());
            Circle circle = new Circle();            
            Console.WriteLine(circle.Area());
            Triangle triangle = new Triangle();          
            Console.WriteLine(triangle.Area());
            Console.ReadKey();

        }
    }
}
