using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace SchoolSystem
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string studentName = "Sami Ali";
                int studentAge = 21;
                int studentGrade = 12;
                double studentAverage = 85.5;
                char studentGender = 'F';
                bool studentActive = false;

                Console.WriteLine("===== Student Information =====");
                Console.WriteLine("Name: " + studentName);
                Console.WriteLine("Age: " + studentAge);
                Console.WriteLine("Grade: " + studentGrade);
                Console.WriteLine("Average: " + studentAverage);
                Console.WriteLine("Gender: " + studentGender);
                Console.WriteLine("Active: " + studentActive);

                Console.WriteLine();

                Console.WriteLine("===== Students =====");

                string[] students = { "LUJAIN", "Ayah", "EMAD", "Taiba" };

                Console.WriteLine("Student 1: " + students[0]);
                Console.WriteLine("Student 2: " + students[1]);
                Console.WriteLine("Student 3: " + students[2]);
                Console.WriteLine("Student 4: " + students[3]);

                Console.WriteLine("Number of Students: " + students.Length);

                Console.WriteLine();

                Console.WriteLine("===== Before Change =====");

                Console.WriteLine(students[0]);
                Console.WriteLine(students[students.Length - 1]);

                students[2] = "Khaled";

                Console.WriteLine("===== After Change =====");

                Console.WriteLine(students[0]);
                Console.WriteLine(students[1]);
                Console.WriteLine(students[2]);
                Console.WriteLine(students[3]);
            }
        }
    }

}
    }
}
