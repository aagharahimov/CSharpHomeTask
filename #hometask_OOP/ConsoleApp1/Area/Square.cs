using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    
    internal class Square : Shape
    {
        public double side { get; set; }
        public double area  = 0;

        public Square(double side)
        {
            this.side = side;
        }

        public override void CalculateArea()
        {
            area = side * side;
            Console.WriteLine($"area of the square with the side of {side} is {area}");
        }
    }
}
