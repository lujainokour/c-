using System;

namespace ArrayExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits =
            {
                "Apple",
                "Banana",
                "Orange",
                "Mango",
                "Kiwi",
                "Strawberry"
            };

            Console.WriteLine("Question 1:");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(i + " - " + fruits[i]);
            }

            Console.WriteLine("Total number of fruits: " + fruits.Length);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            int[] numbers = new int[5];

            Console.WriteLine("Question 2:");
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Reversed Array:");

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            string[] colors =
            {
                "Red",
                "Blue",
                "Rose",
                "Green",
                "Red",
                "Yellow",
                "Royal Blue"
            };

            int count = 0;

            Console.WriteLine("Question 3:");

            for (int i = 0; i < colors.Length; i++)
            {
                if (colors[i].StartsWith("R", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine("Colors starting with R: " + count);

            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine();

            int[] values = new int[6];

            Console.WriteLine("Question 4:");
            Console.WriteLine("Enter 6 numbers:");

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                sum = sum + values[i];
            }

            int min = values[0];
            int max = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }

                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            double average = (double)sum / values.Length;

            Array.Sort(values);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + average);

            Console.Write("Sort: ");

            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i]);

                if (i < values.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
    }
}