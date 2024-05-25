using System;
using System.Collections.Generic;
using System.Linq;

public class Course
{
    private List<Student> students;

    public Course()
    {
        students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        if (!students.Any(s => s.PIN == student.PIN))
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }
        else
        {
            Console.WriteLine("Student with the same PIN exists.");
        }
    }

    public void RemoveStudent(string pin)
    {
        var studentToRemove = students.FirstOrDefault(s => s.PIN == pin);
        if (studentToRemove != null)
        {
            students.Remove(studentToRemove);
            Console.WriteLine("Student removed successfully.");
        }
        else
        {
            Console.WriteLine("No student found with the provided PIN.");
        }
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students to display.");
        }
        else
        {
            Console.WriteLine("List of students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
            }
        }
    }

    public void SearchStudent(string pin)
    {
        var student = students.FirstOrDefault(s => s.PIN == pin);
        if (student != null)
        {
            Console.WriteLine($"Student found: Name: {student.Name}, Surname: {student.Surname}, Age: {student.Age}, PIN: {student.PIN}");
        }
        else
        {
            Console.WriteLine("No student found with this PIN.");
        }
    }

    public int CountTotalStudents()
    {
        return students.Count;
    }

    public int CountStudentsOver18()
    {
        return students.Count(s => s.Age >= 18);
    }
}
