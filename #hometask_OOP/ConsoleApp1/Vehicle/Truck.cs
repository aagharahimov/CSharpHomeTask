using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Truck : Vehicle
    {
        public int loadCapacity { get; set; }
        public Truck(string name, string model, string color, int maxSpeed, double engineCapacity, int fuelCapacity, int loadCapacity) : base(name, model, color, maxSpeed, engineCapacity, fuelCapacity)
        {
            Name = name;
            Model = model;
            Color = color;
            this.maxSpeed = maxSpeed;
            this.engineCapacity = engineCapacity;
            this.fuelCapacity = fuelCapacity;
            this.loadCapacity = loadCapacity;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"truckin detallari: name: {Name} model: {Model} color: {Color} max speed: {maxSpeed} engine cap: {engineCapacity}, fuel cap: {fuelCapacity}, load cap: {loadCapacity}");
        }
    }
}
