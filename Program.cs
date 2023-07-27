using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(8);
            circle.Print();

            Rectangle rectangle = new Rectangle(9, 6);
            rectangle.Print();

            Triangle triangle = new Triangle(1, 3, 8);
            triangle.Print();

            Console.ReadKey();
        }
    }
}
