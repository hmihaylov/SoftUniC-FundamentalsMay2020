using System;

namespace _01.StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:F2}", name, age, grade);

        }
    }
}
