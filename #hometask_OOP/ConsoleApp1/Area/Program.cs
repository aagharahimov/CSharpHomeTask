using Area;

namespace Area
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Square square =  new Square(3.5);
            square.CalculateArea();

            Circle circle = new Circle(2.65);
            circle.CalculateArea();

            Triangle triangle = new Triangle(3,6.5);
            triangle.CalculateArea();



        }
    }
}