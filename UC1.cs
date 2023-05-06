using System;

public class InvalidFirstNameException : Exception
{
    public InvalidFirstNameException() : base("Invalid first name. First name should start with a capital letter and have at least 3 characters.") { }
}

public class UC1
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            if (firstName.Length < 3 || !Char.IsUpper(firstName[0]))
            {
                throw new Exception();
            }

            Console.WriteLine("Valid first name entered: " + firstName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
