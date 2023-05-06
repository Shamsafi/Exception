using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            //Must contain at least one numeric number
            try
            {
                if (password.Length < 8)
                {
                    throw new Exception("Error: Password should be at least 8 characters long.");
                }

                if (!char.IsDigit(password, password.Length - 1))
                {
                    throw new Exception("Error: Password should end with a numeric number.");
                }

                if (char.IsDigit(password, 0) || char.IsSymbol(password, 0) || char.IsPunctuation(password, 0))
                {
                    throw new Exception("Error: Password should not start with a digit or special character.");
                }

                Console.WriteLine("Success: Valid password.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}