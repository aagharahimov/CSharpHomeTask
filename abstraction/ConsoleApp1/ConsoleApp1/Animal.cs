using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public abstract string MakeSound();

    }

    internal class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meow";
        }
        
        
    }

    internal  class Dog : Animal
    {
        public override string MakeSound()
        {
            return "hav";
        }
    }

    internal abstract class Bird : Animal
    {

    }
        
    internal class Eagle : Bird
    {
        public override string MakeSound()
        {
            return "chick-chick";
        }

        
    }
}
