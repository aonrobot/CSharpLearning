using System;

namespace _5_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array!");

            //ประกาศ array
            int[] i = new int[3];
            i[0] = 3;
            i[1] = 5;
            i[2] = 7;

            //ประกาศ array แบบใส่่ค่าทันที
            int[] b = new int[] { 10, 20, 30 };

            //ประกาศ array 2 มิติ
            int[,] c = new int[3, 4];
            c[0, 0] = 10; c[2, 3] = 20; c[1, 1] = 30;

            //ประกาศ array 2 มิติ แบบใส่่ค่าทันที
            int[,] d = new int[,] { { 1, 2, 3 }, { 10, 20, 30 } };

            //Jagged Array
            int[][] f = new int[2][];
            f[0] = new int[5]; f[0][4] = 20;
            f[1] = new int[2]; f[1][1] = 30;

            Console.WriteLine(b.Length); //หาทุก index ทุกมิติ
            Console.WriteLine(b.Rank);
            Console.WriteLine(f.GetLength(0)); //หา index ในมิติที่กรอก
            Console.WriteLine(c.GetUpperBound(0)); //หา index สุดท้ายของมิติที่กรอก

            for (int j = 0; j <= b.Length - 1; j++)
            {
                Console.WriteLine(b[j]);
            }

            foreach (int z in b)
            {
                Console.WriteLine($"Foreach : {z}");
            }
        }
    }
}
