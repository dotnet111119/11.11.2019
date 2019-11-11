using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111
{
    class Program
    {
        static void foo()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int y;
            Console.WriteLine();

            foo();

            int x = 0, sum = 0;
            x = x + 1;
            int count = 0;
            Console.WriteLine();
            object z = new object();
            int u = 1;
            do
            {
                if (count >= 100)
                {
                    break;
                }

                Console.WriteLine("Please enter number: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x <= 0)
                {
                    continue;
                }
                
                count++;

                sum = sum + x;
            }
            while (x >= 0) ;

            //Console.WriteLine("sum " + sum + "AVG" +)
            if (count == 0)
                Console.WriteLine("No numbers....");
            else
                Console.WriteLine($"sum = {sum} AVERGAE = {sum / count }");

            Console.ReadLine();
        }
    }
}
