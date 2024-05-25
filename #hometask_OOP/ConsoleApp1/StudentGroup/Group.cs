using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Group 
    {
        
        public string GroupNo { get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Limit { get; set; }
        private Student[] students;
        public Group(string groupNo, int limit, DateTime startDate, DateTime endDate ) 
        {
            StartDate = startDate;
            EndDate = endDate;
            GroupNo = groupNo;
            Limit = limit;
            students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            if (Limit > students.Length)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
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
            var index = Array.IndexOf(students, student);
            if (index != -1)
            {
                for (int i = index; i < students.Length - 1; i++)
                {
                    students[i] = students[i + 1];
                }

                Array.Resize(ref students, students.Length - 1);
            }

            else
            {
                Console.WriteLine("axtardiginiz mehsul sifarisde yoxdur");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine($"{GroupNo}, {StartDate.ToString("M/d/yyyy")}, {EndDate.ToString("M/d/yyyy")}, {Limit}");
        }


    }
}
