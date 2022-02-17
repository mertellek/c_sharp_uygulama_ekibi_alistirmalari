using System;

namespace hafta_1_alistirma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ad ve soyad bilgisini string değişkenlerine alarak ekrana yazdıran program.
            Console.Write("Adınız : ");
            string name = Console.ReadLine();
            Console.Write("Soyadınız : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba " + name + " " + surname);
            Console.ReadKey();
        }
    }
}
