using System;

namespace _2_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Operator!");

            // Operator

            Console.WriteLine( "A" + "B" );     // "AB"

            Console.WriteLine(5 > 2);           // true

            Console.WriteLine(5 == 2);          // false

            Console.WriteLine(5 != 2);          // true

            Console.WriteLine(true && false);   // false

            Console.WriteLine(true || false);   // true

            Console.WriteLine(true != false);   // true (nor)

            // Read line

            string str = Console.ReadLine();

            Console.WriteLine(str);
        }
    }
}
