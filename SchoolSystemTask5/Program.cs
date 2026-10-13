
using System;

namespace SchoolSystemTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Lujain", 21, "Orange School", 12, 101);
            Student student2 = new Student("Sara", 20, "Orange School", 11, 102);

            Teacher teacher1 = new Teacher("Ahmad", 35, "Orange School", "Math");

            Console.WriteLine("===== Student 1 =====");
            student1.DisplayStudentInfo();

            Console.WriteLine();

            Console.WriteLine("===== Student 2 =====");
            student2.DisplayStudentInfo();

            Console.WriteLine();

            Console.WriteLine("===== Teacher =====");
            teacher1.DisplayTeacherInfo();

            Console.WriteLine();

            // SchoolName is protected, so it cannot be accessed from Main.
            // Console.WriteLine(student1.SchoolName);

            // _internalCode is private, so it cannot be accessed from Main.
            // Console.WriteLine(student1._internalCode);

            Console.WriteLine("===== School Report =====");

            SchoolReport report = new SchoolReport("Students Performance Report");
            report.DisplayReportTitle();

            Console.ReadKey();
        }
    }
}
