using System;
using System.Collections;

namespace hafta_2_alistirma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - 1.000.000 arasındaki asal sayıları listeleme
            bool asalCheck;
            for (ulong i = 2; i <= 1000000; i++)
            {
                asalCheck = false;
                for (ulong j = 2; j < i; j++)
                {
                    if (i % j == 0) { asalCheck = true; break; }
                    if (j == i / 2) break;
                }

                if (asalCheck==false)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
