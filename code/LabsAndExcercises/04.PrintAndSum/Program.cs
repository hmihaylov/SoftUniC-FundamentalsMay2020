using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromNumber = int.Parse(Console.ReadLine());
            int toNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int number = fromNumber; number <= toNumber; number++)
            {
                Console.Write($"{number} ");
                sum += number;
            }

            Console.WriteLine($"\nSum: {sum}");
        }
    }
}
