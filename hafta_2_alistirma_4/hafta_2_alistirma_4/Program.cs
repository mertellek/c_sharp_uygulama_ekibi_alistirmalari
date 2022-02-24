using System;

namespace hafta_2_alistirma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen metindeki sesli harfleri bulan program
            Console.Write("Metni giriniz: ");
            string metin = Console.ReadLine();
            metin = metin.Trim().Replace(" ", string.Empty);
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'a' || metin[i] == 'e' || metin[i] == 'ı' || metin[i] == 'i' || 
                    metin[i] == 'o' || metin[i] == 'ö' || metin[i] == 'u' || metin[i] == 'ü' || 
                    metin[i] == 'A' || metin[i] == 'E' || metin[i] == 'I' || metin[i] == 'İ' || 
                    metin[i] == 'O' || metin[i] == 'Ö' || metin[i] == 'U' || metin[i] == 'Ü')
                {
                    Console.WriteLine("Metnin " + (i+1) + ". elemanı: " + metin[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
