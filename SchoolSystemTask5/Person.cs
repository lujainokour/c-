
using System;

namespace SchoolSystemTask5
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName { get; set; }

        private string _internalCode = "SC123";

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        // _internalCode is private, so it cannot be accessed outside Person.
    }
}
