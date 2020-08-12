using System;
using System.Runtime.CompilerServices;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int factoriel = 1;
                for (int j = 1; j <= int.Parse(number[i].ToString()); j++)
                {
                    factoriel = factoriel * j;
                }
                sum = sum + factoriel;
            }
            if (int.Parse(number) == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
