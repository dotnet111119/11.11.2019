using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] xyz = { 1, 2, 3 };
            string[] words = { "Hello", "C#", "8.0" };

            int[,] matrix =
                {
                    { 1,  2,  3 },
                    { 4,  5,  6 },
                    { 7,  8,  9 },
                    { 8, -2,  1 }
            };
            int[,] mat2 = new int[2, 2];
            mat2[0, 0] = 1;
            mat2[0, 1] = 1;
            mat2[1, 0] = 1;
            mat2[1, 1] = 1;

            int[,] mat3 = new int[3, 2];
            //GetMatrix(mat3);

            int[][] jagged = new int[5][];
            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new int[10];
            }
            Console.WriteLine(jagged[0][1]);
            for (int i = 0; i < jagged[1].GetLength(0); i++)
            {
                Console.WriteLine();
            }

            int[][] jagged_inline = new int[3][]
            {
                new [] { 1,2,3 },
                new [] { 3 },
                new [] { 1,3 },
            };

            char c = 'a';
            char[] c1 = { 'a', 'b' };

            string w1 = "aa.b.c";
            string[] words2 = w1.Split();
        }

        private static void GetMatrix(int[,] mat3)
        {
            for (int i = 0; i < mat3.GetLength(0); i++)
                for (int j = 0; j < mat3.GetLength(1); j++)
                {
                    Console.WriteLine($"Please enter number in {i} {j}");
                    mat3[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }
    }
}
