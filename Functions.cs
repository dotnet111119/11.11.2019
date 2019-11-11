using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program
    {

        static void foo(out int y)
        {
            y = 3;
        }

        static void change_me(ref int x)
        {
            x = 12;
        }

        static int sum(int x, int y = 0, int z = 0)
        {
            return x + y + z;
        }

        static int sum2(int[] nums)
        {
            int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}

            foreach (int item in nums)
            {
                sum += item;
            }

            return sum;
        }


        static int sum3(params int[] nums)
        {
            int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}

            foreach (int item in nums)
            {
                sum += item;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            //int x;
            foo(out int x);
            Console.WriteLine(x);

            x = 0;
            change_me(ref x);
            Console.WriteLine(x);

            Console.WriteLine(sum(1, 2, 3));
            Console.WriteLine(sum(1, 2));
            Console.WriteLine(sum(1, 0, 2));
            Console.WriteLine(sum(1, z : 2));
            Console.WriteLine(sum(y : 1, x : 2));

            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(sum2(numbers));

            Console.WriteLine(sum2(new int[] { 1, 2, 3 }));

            Console.WriteLine(sum3(1,2));
            Console.WriteLine(sum3());
        }
    }
}
