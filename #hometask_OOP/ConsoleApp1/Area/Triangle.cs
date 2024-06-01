using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Triangle : Shape
    {
        private double side;
        private double height;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override void CalculateArea()
        {
            double area = Math.Round((Side * Height) / 2, 2);
            Console.WriteLine($"Area of the triangle with the side {Side} and height {Height} is {area}");
        }
    }
}

