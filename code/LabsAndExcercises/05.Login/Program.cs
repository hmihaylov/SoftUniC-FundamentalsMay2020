using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
            int count = 1;
            string enteredPassword = "";

            for (int i = 1; i <= user.Length; i++)
            {
                password += user.Substring(user.Length - i, 1);
            }

            while (count < 5)
            {
                enteredPassword = Console.ReadLine();
                if (enteredPassword.Equals(password))
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                }
            }

            if (count==5)
            {
                Console.WriteLine($"User {user} blocked!");
            }
        }
    }
}
