using System;

namespace StudentGroup
{
    internal class Topic
    {
        public string Name { get; set; }

        public Topic(string name)
        {
            Name = name;
        }

        public void GetDetails()
        {
            Console.WriteLine(Name);
        }
    }
}
