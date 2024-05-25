

namespace ConsoleApp1
{
    public class Person
    {
       

        public string name;
        public string surname;
        public int age;


        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string GetDetails()
        {
            return $"{name} {surname} {age}";
        }
    }
}
