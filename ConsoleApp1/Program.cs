using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretUser = "admin";
            string secretPassword = "12345";

            Console.WriteLine("Please log in.");
            bool isAuthentificated = false;

            while(!isAuthentificated)
            {
                Console.Write("User: ");
                string user = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                if(string.Equals(user, secretUser, StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(password, secretPassword, StringComparison.Ordinal))
                {
                    Console.WriteLine($"Welcome {user} !");
                    isAuthentificated = true;
                }
                else
                {
                    Console.WriteLine("Wrong. Try again.");
                }
            }
        }
    }
}
