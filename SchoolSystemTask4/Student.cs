
using System;

namespace SchoolSystemTask4
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int Grade;

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine();
        }
    }
}
