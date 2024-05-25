using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProduct
{
    internal class Clothes : Product
    {

        public string Size { get; set; }

        public Clothes(string name,string size, decimal price ) : base(name, price)
        {
            Size = size;

        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name}, {Size}, {Price}");
        }
    }
}
