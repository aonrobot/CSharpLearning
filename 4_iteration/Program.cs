using System;

namespace _4_iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Iteration!");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Hello" + i.ToString());
            }

            int b = 0;
            do
            {
                Console.WriteLine("bye" + b); b++;
            } while (b <= 5); //ทำจนกว่าจะ false

            b = 0;
            while (b <= 5) ; //ทำจนกว่าจะ false
            {
                Console.WriteLine("hi" + b); b++;
            }

            string input;
            do
            {
                input = Console.ReadLine();
                Console.WriteLine("hi" + b); b++;
            } while (input == "y"); //ทำจนกว่าจะ false
        }
    }
}
