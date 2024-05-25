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
            get
            {

            }
            set
            {

            }
        }
        public double area = 0;

        public Circle(double readius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            area = Math.Round(radius * radius * Math.PI, 2);
            Console.WriteLine($"area of the circle with the radius of {radius} is {area}");
        }
    }
}
