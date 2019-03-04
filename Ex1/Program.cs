using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("FisrtName: ________ ");
            string firstName = Console.ReadLine();
            Console.Write("BirthYear: ________ ");
            string birthYear = Console.ReadLine();

            Console.WriteLine("--------------------");

            Console.WriteLine("Your name is " + firstName);
            Console.WriteLine("Your birthyear is " + birthYear);

            int age = DateTime.Now.Year - int.Parse(birthYear);
            Console.WriteLine("Your age is (age)" + age);


            // Tip: string template

            Console.WriteLine(" ------- string template --------- ");
            Console.WriteLine("Your name is {0}", firstName);

            string name = String.Format("Your name is {0}", firstName);

            Console.WriteLine("C:\folder\file.txt"); // bad
            Console.WriteLine("C:\\folder\\file.txt"); // good
            Console.WriteLine(@"C:\folder\file.txt"); // good
        }
    }
}
