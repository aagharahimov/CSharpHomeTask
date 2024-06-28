using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Square : Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square(double side)
        {
            Side = side;
        }

        public override void CalculateArea()
        {
            double area = Math.Round(Side * Side, 2);
            Console.WriteLine($"Area of the square with the side of {Side} is {area}");
        }
    }
}
