using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            if (numberOfPersons >= 30)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons * 0.85);
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        case "Saturday":
                            price = 9.80;
                            if (numberOfPersons >= 30)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons * 0.85);
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        case "Sunday":
                            price = 10.46;
                            if (numberOfPersons >= 30)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons * 0.85);
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            if (numberOfPersons >= 100)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * (numberOfPersons - 10));
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        case "Saturday":
                            price = 15.60;
                            if (numberOfPersons >= 100)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * (numberOfPersons - 10));
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        case "Sunday":
                            price = 16;
                            if (numberOfPersons >= 100)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * (numberOfPersons - 10));
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            if (10 <= numberOfPersons && numberOfPersons <= 20)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons * 0.95);
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        case "Saturday":
                            price = 20;
                            if (10 <= numberOfPersons && numberOfPersons <= 20)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons * 0.95);
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        case "Sunday":
                            price = 22.50;
                            if (10 <= numberOfPersons && numberOfPersons <= 20)
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons * 0.95);
                            }
                            else
                            {
                                Console.WriteLine("Total price: {0:F2}", price * numberOfPersons);
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
