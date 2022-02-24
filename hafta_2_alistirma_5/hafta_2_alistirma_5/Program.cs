using System;

namespace hafta_2_alistirma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 10 adet sayı alarak bu sayıların toplamını ekranda gösteren program
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. Sayıyı giriniz: ",i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            Console.WriteLine("Girmiş olduğunuz sayıların toplamı= " + toplam);
            Console.ReadKey();
        }
    }
}
