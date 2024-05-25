using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal abstract class Product
    {   
        public string Name { get; set; }
        public decimal Price { get; set; }
        

        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;

        }


        public abstract void GetDetails();
    }
}
