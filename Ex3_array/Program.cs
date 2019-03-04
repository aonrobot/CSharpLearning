using System;

namespace Ex3_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // กรอกชื่อ 3 รอบ แล้วโชว์ชื่อ 3 ครั้ง

            string[] names = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("First Name : ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("-----------------------------");

            foreach (string name in names)
            {
                Console.WriteLine("FirstName? is {0}", name);
            }
        }
    }
}
