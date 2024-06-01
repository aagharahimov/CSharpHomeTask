using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Animal
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public string Cins { get; set; }
        public string Reng { get; set; }

        public Animal(string ad, int yas, string cins, string reng)
        {
            Ad = ad;
            Yas = yas;
            Cins = cins;
            Reng = reng;
        }

        public abstract void SesCixarmaq();
    }
}
