
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
            Console.WriteLine("Enter Student Information:");

            Console.Write("Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Student Age: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Grade: ");
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Student Average: ");
            double studentAverage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Student Gender: ");
            string studentGender = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("===== Student Report =====");

            Console.WriteLine("Welcome " + studentName + "!");
            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("Gender: " + studentGender);

            Console.WriteLine();
            Console.WriteLine("===== Name Information =====");

            Console.WriteLine("Original Name: " + studentName);
            Console.WriteLine("Uppercase: " + studentName.ToUpper());
            Console.WriteLine("Lowercase: " + studentName.ToLower());
            Console.WriteLine("First Character: " + studentName[0]);

            Console.WriteLine();
            Console.WriteLine("===== Student Calculation =====");

            double newAverage = studentAverage + 5;

            Console.WriteLine("Original Average: " + studentAverage);
            Console.WriteLine("Bonus Marks: 5");
            Console.WriteLine("New Average: " + newAverage);

            Console.WriteLine();
            Console.WriteLine("===== Student Status =====");

            bool passed = newAverage >= 50;
            bool adult = studentAge >= 18;
            bool passedAndAdult = passed && adult;
            Console.WriteLine("Passed and Adult: " + passedAndAdult);

            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine("Passed: " + passed);
            Console.WriteLine("Adult: " + adult);

            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("        STUDENT SUMMARY");
            Console.WriteLine("================================");

            Console.WriteLine("Welcome " + studentName.ToUpper() + "!");

            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine("Gender: " + studentGender);

            if (passed)
            {
                Console.WriteLine("Result: Passed");
            }
            else
            {
                Console.WriteLine("Result: Failed");
            }

            Console.WriteLine("Adult: " + adult);

            Console.WriteLine("================================");
        }
    }
}
