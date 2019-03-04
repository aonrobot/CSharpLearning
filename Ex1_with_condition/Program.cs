using System;

namespace Ex1_with_condition
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


            int birthYearInt = int.Parse(birthYear);

            bool checkBirthYear = (birthYearInt <= DateTime.Now.Year && birthYear.Length == 4) ? true : false;

            if (checkBirthYear)
            {
                Console.WriteLine(String.Format("Your birthyear is {0}", birthYear));

                int age = DateTime.Now.Year - int.Parse(birthYear);

                Console.WriteLine("Your age is (age)" + age);

            } else {
                Console.WriteLine("BirthYear is incorrect");
            }

        }
    }
}
