using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program
    {

        static void Modify(int[] arr)
        {
            arr[0] = -12;
        }

        static int[] DontModify(int[] arr)
        {
            int[] result = new int[arr.Length];
            int i = 0;
            foreach (var item in arr)
            {
                result[i++] = item;
            }
            result[0] = -12;
            return result;
        }

        static void Main(string[] args)
        {
            int[] xyz = { 1, 2, 3 };
            int[] wyz = new[] { 1, 2, 3 };

            int[] numbers = new int[10];

            Console.WriteLine(xyz[0]);
            Modify(xyz);
            Console.WriteLine(xyz[0]);

            int[] xyzz = { 1, 2, 3 };
            int[] result = DontModify(xyzz);

        }
    }
}
