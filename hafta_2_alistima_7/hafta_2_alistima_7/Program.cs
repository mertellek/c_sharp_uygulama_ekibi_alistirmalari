using System;

namespace hafta_2_alistima_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği metni kullanıcının girdiği kadar ekranda yazdıran program
            Console.Write("Lütfen yazdırmak istediğiniz metni giriniz: ");
            string metin = Console.ReadLine();
            Console.Write("Kaç adet yazdırmak istediğiniz giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(metin);
            }
            Console.ReadKey();
        }
    }
}
