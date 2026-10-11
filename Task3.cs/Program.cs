
using System;

namespace SchoolSystem
{
    internal class Task3
    {
        public static void Run()
        {
            // Part 1 - Guessing Game

            Random random = new Random();
            int secretNumber = random.Next(50, 76);
            int guess = 0;
            int attempts = 0;
            int points = 0;

            Console.WriteLine("===== Guessing Game =====");

            while (guess != secretNumber)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Try a lower number.");
                }
                else
                {
                    Console.WriteLine("Congratulations!");
                }
            }

            if (attempts == 1)
            {
                points = 10;
            }
            else if (attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);

            // Part 2 - School System

            string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
            int[] grades = { 85, 92, 68, 75, 90 };

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("===== Students =====");

                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }

                        Console.WriteLine("===== Grades =====");

                        foreach (int grade in grades)
                        {
                            Console.WriteLine(grade);
                        }
                        break;

                    case 2:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        int index = 0;
                        bool found = false;

                        while (index < students.Length)
                        {
                            if (students[index].Equals(name, StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                Console.WriteLine("Student Found!");
                                break;
                            }

                            index++;
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter student grade: ");
                        int gradeResult = Convert.ToInt32(Console.ReadLine());

                        if (gradeResult >= 90 && gradeResult <= 100)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (gradeResult >= 80 && gradeResult <= 89)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (gradeResult >= 70 && gradeResult <= 79)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (gradeResult >= 60 && gradeResult <= 69)
                        {
                            Console.WriteLine("Pass");
                        }
                        else if (gradeResult >= 0 && gradeResult < 60)
                        {
                            Console.WriteLine("Fail");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Grade");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
