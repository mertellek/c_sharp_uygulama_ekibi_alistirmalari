using System;

namespace hafta_2_alistirma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - N arası 3'e ve 7' ye tam bölünen sayıları listeleme
            Console.Write("Lütfen N sayısını giriniz: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i%3==0 && i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
