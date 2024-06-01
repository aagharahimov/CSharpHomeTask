using System;

namespace StudentGroup
{
    internal class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Teacher(string name, string surname)
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
