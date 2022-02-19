using System;

namespace hafta_1_alistirma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vücut Kitle İndeksi hesaplayan program.
            Console.Write("Lütfen boyunuzu metre cinsinden arada virgül olacak şekilde giriniz: ");
            double boy = double.Parse(Console.ReadLine());
            Console.Write("Lütfen kilonuzu kilogram cinsinden giriniz: ");
            double kilo = double.Parse(Console.ReadLine());
            Console.WriteLine("Vücut Kitle Endeksiniz: " + (kilo / (boy * boy)));
            Console.ReadKey();
        }
    }
}
