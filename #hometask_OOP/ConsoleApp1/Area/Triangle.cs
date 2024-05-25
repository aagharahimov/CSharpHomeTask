using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Triangle : Shape
    {
        public double side { get; set; }
        public double height { get; set; }
        public double area = 0;

        public Triangle(double side, double height) 
        {
            this.side = side;
            this.height = height;
        }

        public override void CalculateArea()
        {
            area = (side * height)/2;
            Console.WriteLine($"area of the triangle with the side {side} and height {height} is {area}");
        }


    }
}
