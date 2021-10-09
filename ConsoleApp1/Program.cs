using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, l;

            k = Convert.ToInt32(Console.ReadLine());
            l = Convert.ToInt32(Console.ReadLine());

            int tempSum;
            int sum = 0;

            for (k = 1; k <= 10; k++)
            {
                tempSum = Convert.ToInt32(Math.Pow(k, 3));

                for (l = 1; l <= 15; l++)
                {
                    sum += tempSum * (k - l) * (k - l);
                }
            }

            Console.WriteLine("Summa = " + sum);
            Console.ReadKey();
        }
    }
}
