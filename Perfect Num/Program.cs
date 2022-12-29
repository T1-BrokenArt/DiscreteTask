using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Let's Check Your Perfect Numbers.\n\n");
            Console.WriteLine("Pick Your First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick Your Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nCongratulation We Find Your Perfect Numbers.");
            Console.Write("\nYour Perfect Numbers is: \n");

            for (int x = num1; x <= num2; x++)
            {
                int divisor_sum = 0;

                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        divisor_sum += y;
                    }

                }

                if (divisor_sum == x && x > 0)
                    Console.WriteLine(". " + x);

            }

            Console.WriteLine("\nTHANK YOU.");
            Console.ReadKey();
        }
    }
}
