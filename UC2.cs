using System;

public class InvalidLastNameException : Exception
{
    public InvalidLastNameException() : base("Invalid last name. Last name should start with a capital letter and have at least 3 characters.") { }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            if (lastName.Length < 3 || !Char.IsUpper(lastName[0]))
            {
                throw new Exception();
            }

            Console.WriteLine("Valid last name entered: " + lastName);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
