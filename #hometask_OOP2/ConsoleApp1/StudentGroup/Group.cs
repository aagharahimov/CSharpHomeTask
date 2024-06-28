using System;
using System.Collections.Generic;

namespace StudentGroup
{
    internal class Group
    {
        public string GroupNo { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int Limit { get; }
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Topic> topics;

        public Group(string groupNo, int limit, DateTime startDate, DateTime endDate)
        {
            GroupNo = groupNo;
            Limit = limit;
            StartDate = startDate;
            EndDate = endDate;
            students = new List<Student>();
            teachers = new List<Teacher>();
            topics = new List<Topic>();
        }

        public void AddStudent(Student student)
        {
            if (students.Count < Limit)
            {
                students.Add(student);
            }
            else
            {
                Console.WriteLine("Group is full.");
            }
        }

        public void GetStudents()
        {
            foreach (var student in students)
            {
                student.GetDetails();
            }
        }

        public void RemoveStudent(Student student)
        {
            if (students.Remove(student))
            {
                Console.WriteLine($"{student.Name} {student.Surname} has been removed.");
            }
            else
            {
                Console.WriteLine("Student not in this group.");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"{GroupNo}, {StartDate:dd-mm-yyyy}, {EndDate:dd-mm-yyyy}, {Limit}");
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (teachers.Remove(teacher))
            {
                Console.WriteLine($"{teacher.Name} {teacher.Surname} has been removed.");
            }
            else
            {
                Console.WriteLine("Teacher not in this group.");
            }
        }

        public void GetTeachers()
        {
            foreach (var teacher in teachers)
            {
                teacher.GetDetails();
            }
        }

        public void AddTopic(Topic topic)
        {
            topics.Add(topic);
        }

        public void RemoveTopic(Topic topic)
        {
            if (topics.Remove(topic))
            {
                Console.WriteLine($"{topic.Name} has been removed.");
            }
            else
            {
                Console.WriteLine("Topic not in this group.");
            }
        }

        public void GetTopics()
        {
            foreach (var topic in topics)
            {
                topic.GetDetails();
            }
        }
    }
}
