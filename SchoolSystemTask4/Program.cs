
using System;

namespace SchoolSystemTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ahmad", 20, 85);
            Student student2 = new Student("Sara", 21, 92);
            Student student3 = new Student("Omar", 19, 78);

            Console.WriteLine("===== Student Information =====");

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
        }
    }
}
