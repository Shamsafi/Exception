using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            try
            {
                Regex regex = new Regex(@"^91\s[1-9][0-9]{9}$");

                if (regex.IsMatch(mobileNumber))
                {
                    Console.WriteLine("Success: Valid mobile number.");
                }
                else
                {
                    throw new Exception("Exception Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}