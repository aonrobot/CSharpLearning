using System;

namespace _6_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Method!");

            ShowFullName("Auttawut", "Alexander III");
        }

        static string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }

        static void ShowFullName(string FirstName, string LastName)
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
