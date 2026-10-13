
using System;

namespace SchoolSystemTask5
{
    internal class Student : Person
    {
        public int Grade { get; set; }
        public int StudentId { get; set; }

        public Student(string name, int age, string schoolName,
            int grade, int studentId)
            : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("School: " + SchoolName);
        }
    }
}
