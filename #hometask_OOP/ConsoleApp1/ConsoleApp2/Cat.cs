using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cat : Animal
    {
        public Cat(string ad, int yas, string cins, string reng ) : base (ad, yas, cins, reng )
        { 
        
        }
        public override void SesCixarmaq()
        {
            Console.WriteLine("Miyav");
        }
    }

    
}
