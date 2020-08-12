using System;
using System.Runtime.CompilerServices;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Start")
            {
                switch (input)
                {
                    case "0.1":
                    case "0.2":
                    case "0.5":
                    case "1":
                    case "2": sum = sum + double.Parse(input); break;

                    default:
                        Console.WriteLine($"Cannot accept {input}");
                        break;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            double singlePrice = 0;

            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts": singlePrice = 2.0; break;
                    case "Water": singlePrice = 0.7; break;
                    case "Crisps": singlePrice = 1.5; break;
                    case "Soda": singlePrice = 0.8; break;
                    case "Coke": singlePrice = 1.0; break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                if (singlePrice != 0)
                {
                    if (sum - singlePrice >= 0)
                    {
                        sum = sum - singlePrice;
                        Console.WriteLine($"Purchased {input}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
