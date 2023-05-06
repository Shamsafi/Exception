using System;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = { "sample@mail.com", "sample.mail.com", "sample@mail" };

            foreach (string email in emails)
            {
                try
                {
                    if (!IsValidEmail(email))
                    {
                        throw new Exception($"Error: {email} is not a valid email address.");
                    }

                    Console.WriteLine($"Success: {email} is a valid email address.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}