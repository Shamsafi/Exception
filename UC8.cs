using System;

public class Program
{
    public static void Main(string[] args)
    {  // Must have 1 special char
        try
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (!IsValidPassword(password))
            {
                throw new Exception("Invalid password entered.");
            }

            Console.WriteLine("Valid password entered: " + password);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static bool IsValidPassword(string password)
    {

        if (password.Length < 8)
        {
            return false;
        }

        if (!password.Any(char.IsUpper))
        {
            return false;
        }

        if (!password.Any(char.IsLower))
        {
            return false;
        }

        if (!password.Any(char.IsDigit))
        {
            return false;
        }

        int specialCharCount = password.Count(c => !char.IsLetterOrDigit(c));
        if (specialCharCount != 1)
        {
            return false;
        }

        return true;
    }
}
