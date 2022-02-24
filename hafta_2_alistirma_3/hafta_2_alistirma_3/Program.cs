using System;

namespace hafta_2_alistirma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziyi alfabetik olarak sıralama(Kullanıcının gireceği kelimelerden oluşan diziyi alfabetik olarak sıralama)
            Console.WriteLine("Lütfen kelimeleri aralarında birer boşluk olacak şekilde giriniz: ");
            string metin = Console.ReadLine();
            string[] metinler = metin.Split(" "); //"metin" ifadesini boşluktan itibaren ayırıp "metinler" dizisine aktarır
            Array.Sort(metinler);
            foreach (var item in metinler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
