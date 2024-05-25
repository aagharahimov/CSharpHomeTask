using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : Vehicle
    {
        public int passangeerCapacity { get; set; }
        public Car(string name, string model, string color, int maxSpeed, double engineCapacity, int fuelCapacity, int passangerCapacity) : base( name, model, color, maxSpeed, engineCapacity, fuelCapacity) 
        {
            Name = name;
            Model = model;
            Color = color;
            this.maxSpeed = maxSpeed;
            this.engineCapacity = engineCapacity;
            this.fuelCapacity = fuelCapacity;
            this.passangeerCapacity = passangerCapacity;

            
        }

        public override void GetDetails()
        {
            Console.WriteLine($"masinin detallari: name: {Name} model: {Model} color: {Color} max speed: {maxSpeed} engine cap: {engineCapacity}, fuel cap: {fuelCapacity}, passsanger cap: {passangeerCapacity}");
        }


    }
}
