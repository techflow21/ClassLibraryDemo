using ClassLibraryDemo;

namespace DemoLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name:");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string? lastName = Console.ReadLine();

            string response = PersonProcessor.GetPersonDetails(firstName, lastName);
            Console.WriteLine($"The Person full name is : {response}");
        }
    }
}