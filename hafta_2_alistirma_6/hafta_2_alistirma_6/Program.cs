using System;

namespace hafta_2_alistirma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayarın rastgele tuttuğu 10 sayıdan çift ve tek olanların sayısını gösteren program
            int tek = 0, cift = 0;
            for (int i = 0; i < 10; i++)
            {
                Random x = new Random();
                int sayi = x.Next();
                if (sayi % 2 == 0) cift++;
                else tek++;
            }
            Console.WriteLine("Üretilen 10 adet rastgele sayının {0} adeti çift, {1} adeti tektir.",cift,tek);
            Console.ReadKey();
        }
    }
}
