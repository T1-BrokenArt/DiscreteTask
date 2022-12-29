using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Let's Check Your Prime Numbers.\n\n");
            Console.WriteLine("Pick Your First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick Your Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nCongratulation We Find Your Prime Numbers.");
            Console.Write("\nYour Prime Numbers is: \n");

            for (int x = num1; x <= num2; x++)
            {
                int Bushido_Counter = 0;

                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        Bushido_Counter++;
                        break;
                    }
                }

                if (Bushido_Counter == 0 && x > 1)
                    Console.WriteLine(". " + x);
            }

            Console.WriteLine("\nTHANK YOU.");
            Console.ReadKey();
        }
    }
}
