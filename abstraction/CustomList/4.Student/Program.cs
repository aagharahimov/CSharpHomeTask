public static class Program
{
    public static void Main(string[] args)
    {
        Course course = new Course();
        while (true)
        {
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Remove a student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Search for a student");
            Console.WriteLine("5. Count total students");
            Console.WriteLine("6. Count students over 18");
            Console.WriteLine("7. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Enter PIN: ");
                    string pin = Console.ReadLine();
                    Student student = new Student(name, surname, age, pin);
                    course.AddStudent(student);
                    break;
                case 2:
                    Console.Write("Enter PIN of the student to remove: ");
                    string removePin = Console.ReadLine();
                    course.RemoveStudent(removePin);
                    break;
                case 3:
                    course.DisplayAllStudents();
                    break;
                case 4:
                    Console.Write("Enter PIN of the student to search: ");
                    string searchPin = Console.ReadLine();
                    course.SearchStudent(searchPin);
                    break;
                case 5:
                    Console.WriteLine("Total students: " + course.CountTotalStudents());
                    break;
                case 6:
                    Console.WriteLine("students over 18: " + course.CountStudentsOver18());
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Invalid choice. please try again.");
                    break;
            }
        }
    }
}