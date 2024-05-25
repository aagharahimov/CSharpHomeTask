using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class Electronic : Product
    {
        public string Material { get; set; }

        public Electronic(string name, decimal price, string Material) : base (name, price)
        {
            name = Name;
            price = Price;
            this.Material = Material;

        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name}, {Material}, {Price}"); ;    
        }
    }
}
