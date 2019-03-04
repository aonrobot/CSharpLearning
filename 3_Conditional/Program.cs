using System;

namespace _3_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Conditional!");

            if (true)
            {
                Console.WriteLine("First");
            }
            else if (true)
            {
                Console.WriteLine("Second");
            }
            else if (true)
            {
                Console.WriteLine("Third");
            }
            else
            {
                Console.WriteLine("Forth");
            }

            int a = 2;
            switch (a)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("else");
                    break;
            }

            int b; b = 2; string c;

            c = b == 1 ? "one" : "two";   //short if
            c = b == 1 ? "one" : b == 2 ? "two" : "three";

            Console.WriteLine(c);
        }
    }
}
