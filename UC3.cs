using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your email:");
            string email = Console.ReadLine();

            try
            {
                Regex regex = new Regex(@"^[a-z0-9]+([._+\-][a-z0-9]+)*@[a-z0-9]+(\.[a-z]{2,3}){1,2}$");

                if (regex.IsMatch(email))
                {
                    Console.WriteLine("Success: Valid email address.");
                }
                else
                {
                    throw new Exception("Error: Invalid email address.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}