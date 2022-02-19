using System;

namespace hafta_1_alistirma_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cümledeki harf sayısını bulan program.
            Console.Write("Lütfen metni girin: ");
            string metin = Console.ReadLine();
            //metin = metin.Trim().Replace(" ", string.Empty); //metindeki tüm boşlukları temizler
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖQPRŞTUÜVWXYZabcçdefgğhıijklmnoöqprsştuüvwxyz";
            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (harfler.Contains(metin[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("Girmiş olduğunuz ifadede " + sayac + " harf bulunuyor.");
            Console.ReadKey();
        }
    }
}
