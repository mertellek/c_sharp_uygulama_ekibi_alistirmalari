using System;

namespace hafta_1_alistirma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının 0-100 arasında olup olmadığını kontrol eden program.
            Console.Write("Sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi <= 100 && sayi >= 0) Console.WriteLine(sayi + " sayısı 0-100 aralığındadır.");
            else Console.WriteLine(sayi + " sayısı 0-100 aralığında değildir.");
            Console.ReadKey();
        }
    }
}
