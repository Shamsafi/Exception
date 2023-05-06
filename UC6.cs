using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            try
            {
                //Should have at least 1 Upper Case - NOTE – All rules must
                Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?!.*[^\w\s]).{8,}$");

                if (regex.IsMatch(password))
                {
                    Console.WriteLine("Success: Valid password.");
                }
                else
                {
                    throw new Exception("Error: Invalid password.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}