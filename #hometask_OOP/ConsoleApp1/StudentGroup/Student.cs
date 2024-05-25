using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentGroup
{
    internal class Student 
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public Student (string name, string surname) 
        {
            Name = name;
            Surname = surname;
        }

        public void GetDetails()
        {
            Console.WriteLine($"{Name}, {Surname}");

        }
    }

    
}
