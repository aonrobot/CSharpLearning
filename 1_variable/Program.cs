using System;

namespace _1_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Variable");

            int a;
            int c, d;

            // Whole number
            int integer; // 32bit
            short shorter; // 16bit
            long longer; // 64bit

            uint unsign_integer;

            // Decimal Number
            float f;
            f = 5.234F; // add suffix to convert double to float

            double dou;
            dou = 5.234;

            decimal dec;
            dec = 4.43211M;

            // Boolean (true, false)
            bool boo; boo = true;

            // Character
            char ch; ch = 'C';
            string str; str = "String";

            // convert

            int n; n = 5;
            double o; o = n; // Widening (Implicit conversion)
            o = 5.23; //n = o; (Narrowing) 
            n = (int)0; // Explicit conversion

            // Number to string

            int p = 25;
            string q; q = p.ToString();

            // String to Number
            q = "25"; p = int.Parse(q);

        }
    }
}
