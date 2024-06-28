using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            double area = Math.Round(Radius * Radius * Math.PI, 2);
            Console.WriteLine($"Area of the circle with the radius of {Radius} is {area}");
        }
    }
}