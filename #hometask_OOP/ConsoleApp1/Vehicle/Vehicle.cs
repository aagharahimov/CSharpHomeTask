using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int maxSpeed { get; set; }
        public double engineCapacity { get; set; }
        public int fuelCapacity { get; set; }

        public Vehicle(string name, string model, string color, int maxSpeed, double engineCapacity, int fuelCapacity)
        {
            Name = name;
            Model = model;
            Color = color;
            this.maxSpeed = maxSpeed;
            this.engineCapacity = engineCapacity;
            this.fuelCapacity = fuelCapacity;
        }

        public virtual void GetDetails()
        {
            Console.WriteLine();
        }
    }

    
}
